using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homiepure.wizard
{
    public partial class FrmWizardContainer : Form
    {
        private readonly WizardMap _wizardMap;
        public CancellationTokenSource CancelTokenSource;
        public Stopwatch StopWatch = new Stopwatch();
        public TimeSpan TimeSpan;

        public FrmWizardContainer(WizardMap wizardMap)
        {
            _wizardMap = wizardMap;

            InitializeComponent();

            ClientSize = new System.Drawing.Size(1013, 580);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            WizardMap.FrmWizardContainer = this;
            tsbBack.Enabled = false;
            _wizardMap.CurrentPage.Control.Dock = DockStyle.Fill;
            lblTaskDescription.Text = _wizardMap.CurrentPage.TaskDescription;

            pcWizPage.Controls.Add(_wizardMap.CurrentPage.Control);

            CenterHorizontally(this, ucTaskProgress);
            CenterVertically(this, ucTaskProgress);
        }
        // Upon page load, in this case next, loads some preferences for the loaded or current wizard page,
        // Structurally, most wizard-pages share similarities,
        // This Next event removes previous page and loads current page with all its properties,
        // In other words, whenever a page is loaded it is assigned its own properties as new
        public void sbNext_Click(object sender, EventArgs e)
        {
            tsbBack.Enabled = true;
            tsbNext.Text = @"Next >";

            // pcWizPage is a control-panel which is the area where all wizard pages loaded and unloaded

            // removes/unload an already loaded wizard-page, makes room for the next wizard-page
            pcWizPage.Controls.Remove(_wizardMap.CurrentPage.Control);

            // do some common task(s), current loaded wizard-page may have something to do/process
            // then let it here
            _wizardMap.CurrentPage.DoTask(new object());

            // hold/put current wizard-page on previous page, enables to go back
            _wizardMap.PreviousPage = _wizardMap.CurrentPage;

            // On Leave - when next button is hit
            // if wizard page leaves - do/process something valid when current loaded wizard-page leaves 
            _wizardMap.CurrentPage.DoTaskOnNextLeaveEventHandler(new object(), new EventArgs());

            // Increment Wizard PageNumber by 1 -> equivalent to pagginating
            WizardMap.PageNumber += 1;
            //pcWizPage.Controls[_wizardMap.CurrentPage.Name].Visible = false;
            // assign current page with next page
            _wizardMap.CurrentPage = _wizardMap.NextPage;
            // this will fills parent area
            _wizardMap.CurrentPage.Control.Dock = DockStyle.Fill;

            // center both vertically and horizontally the current loaded wizard-page on the main window
            CenterHorizontally(pcWizPage, _wizardMap.CurrentPage.Control);
            CenterVertically(pcWizPage, _wizardMap.CurrentPage.Control);

            // this actually adds/loads the control
            pcWizPage.Controls.Add(_wizardMap.CurrentPage.Control);

            // display/change the description of the current loaded wizard-page
            lblTaskDescription.Text = _wizardMap.CurrentPage.TaskDescription;
            // turn visibility on
            pcWizPage.Controls[_wizardMap.CurrentPage.Name].Visible = true;

            // if current page is the last page,
            if (WizardMap.PageNumber == WizardMap.WizardPages.Count)
            {
                tsbCancel.Enabled = true;
                tsbNext.Enabled = false;
            }

            // if current page requires to perform some time-taking task even if
            // current-page's position is last or anywhere else
            if (_wizardMap.CurrentPage.HasAction)
            {
                // do something valid here, similar to doing this in on DoTaskOnLoadEventHandler page's load event
                // DoTaskOnLoadEventHandler is the place where it is recommended to right specific behaviors
            }

            // On Load
            // On wizard-page loads, this will be executed when next button is hit
            _wizardMap.CurrentPage.DoTaskOnLoadEventHandler(new object(), new EventArgs());

            // find the next page control from glob container
            // next page => current-page + one
            _wizardMap.NextPage = WizardMap.WizardPages.Find(p => p.Index == WizardMap.PageNumber + 1);
        }
        // The Back command button does everything simlar to that of Next command button, 
        //except this time, it does reverse the load job  
        private void sbBack_Click(object sender, EventArgs e)
        {
            // On current-wizard-page leaves, this will be executed when back button is hit
            _wizardMap.CurrentPage.DoTaskOnBackLeaveEventHandler(new object(), new EventArgs());

            _wizardMap.NextPage = _wizardMap.CurrentPage;
            // Decrement Wiz PageNumber by 1
            WizardMap.PageNumber -= 1;
            tsbNext.Enabled = true;
            tsbCancel.Enabled = true;
            tsbNext.Text = @"Next >";
            pcWizPage.Controls[_wizardMap.CurrentPage.Name].Visible = false;
            _wizardMap.CurrentPage = _wizardMap.PreviousPage;

            pcWizPage.Controls.Add(_wizardMap.CurrentPage.Control);

            lblTaskDescription.Text = _wizardMap.CurrentPage.TaskDescription;
            //pcWizPage.Controls[_wizardMap.CurrentPage.Name].BringToFront();
            pcWizPage.Controls[_wizardMap.CurrentPage.Name].Visible = true;
            // Find the next page control from glob container
            _wizardMap.PreviousPage = WizardMap.WizardPages.Find(p => p.Index == WizardMap.PageNumber - 1);
            tsbNext.Enabled = true;

            if (WizardMap.PageNumber == 1)
                tsbBack.Enabled = false;
        }
        public void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void timerTaskCounter_Tick(object sender, EventArgs e)
        {
            TimeSpan = StopWatch.Elapsed;
            //string elapsedTime =
            //    $"{TimeSpan.Hours:00}:{TimeSpan.Minutes:00}:{TimeSpan.Seconds:00}.{TimeSpan.Milliseconds / 10:00}";
            // string elapsedTime = $"{TimeSpan.Hours:00}:{TimeSpan.Minutes:00}:{TimeSpan.Seconds:00}";
            string elapsedTime = $"{TimeSpan.Hours:00}:{TimeSpan.Minutes:00}:{TimeSpan.Seconds:00}";
            tslElapsedTime.Text = elapsedTime;
        }
        // this event is interlocked with a command button that requires asynchronous task processings
        // please look inside
        public void sbRepair_Click(object sender, EventArgs e)
        {
            CancelTokenSource = new CancellationTokenSource();

            CancellationToken token = CancelTokenSource.Token;

            var task = Task.Factory.StartNew(() => _wizardMap.CurrentPage.DoWorkInProgress(true), token);

            task.ContinueWith(t =>
            {
                if (StopWatch.IsRunning)
                {
                    StopWatch.Stop();
                }

                switch (task.Status)
                {
                    case TaskStatus.Canceled: // Async task was cancelled.
                        MessageBox.Show(@"Task has been terminated.", @"Operation Cancelled",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case TaskStatus.Created:
                        break;
                    case TaskStatus.Faulted: // Async task failed
                        //MessageBox.Show($"Please try again. : \n{t.Exception}", @"Operation Failed",
                        //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(@"Please try again. :\n" + t.Exception, @"Operation Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case TaskStatus.RanToCompletion: // Async task completed.
                        MessageBox.Show(@"<completion status info>.", @"Operation Completed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case TaskStatus.Running:
                        break;
                    case TaskStatus.WaitingForActivation:
                        break;
                    case TaskStatus.WaitingForChildrenToComplete:
                        break;
                    case TaskStatus.WaitingToRun:
                        break;
                }

                ResetTask();
                CancelTokenSource = null;
            }, token);
        }
        public void CancelTaskButton_Click(object sender, EventArgs e)
        {
            // token source is null if Close button is clicked without task started
            //CancelTokenSource?.Cancel();

            if (CancelTokenSource != null)
            {
                CancelTokenSource.Cancel();
            }
        }
        public void ResetTask()
        {
            try
            {
                Invoke((MethodInvoker)(() =>
                {
                    tsbNext.Enabled = false;
                    tspbTaskProgressBar = new ToolStripProgressBar();
                    tsbCancel.Enabled = true;
                    tslElapsedTime.Text = @"00:00:00";
                }));
            }
            catch
            {
                // ignored
            }
        }

        #region Methods

        public void CenterHorizontally(Control parent, Control control)
        {
            control.Left = (parent.Width - control.Width) / 2;
        }
        public void CenterVertically(Control parent, Control control)
        {
            control.Top = (parent.Height - control.Height) / 2;
        }
        public void ShowWorkInprogressNotification(string message)
        {
            //Task.Run(() =>
            //{
            Invoke((MethodInvoker)(() =>
            {
                ucTaskProgress.DisplayStatus(message);
                ucTaskProgress.Visible = true;
            }));
            //});
        }
        public void HideWorkInprogressNotification()
        {
            Invoke((MethodInvoker)(() =>
            {
                ucTaskProgress.Visible = false;
            }));
        }
        public void ResetThis()
        {
            //
            // TODO: Reset this wizard-form to original state
            //
        }

        #endregion
    }
}
