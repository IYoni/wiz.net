using System;
using System.Windows.Forms;

namespace homiepure.wizard.UserControls
{
    public partial class UcPageExtendable : WizardPage
    {
        public WizardMap.PageDoTask DoTaskHandler = DoTask;
        private delegate void UiHelperDelegate(bool working);
        
        public UcPageExtendable()
        {
            InitializeComponent();

            DoTaskOnNextLeaveEventHandler += DoTaskOnNextLeave;
            DoTaskOnLoadEventHandler += DoTaskOnLoad;
            DoTaskOnChangeEventHandler += DoTaskOnChange;
            DoTaskOnBackLeaveEventHandler += DoTaskOnBackLeave;
        }
        private void cbTable_CheckedChanged(object sender, EventArgs e)
        {
            HasChanges = true;
        }
        private void cbField_CheckedChanged(object sender, EventArgs e)
        {
            HasChanges = true;
        }
        private void cbView_CheckedChanged(object sender, EventArgs e)
        {
            HasChanges = true;
        }
        private void cbStoredProc_CheckedChanged(object sender, EventArgs e)
        {
            HasChanges = true;
        }
        public static void DoTask(object sender)
        {

        }
        private void DoTaskOnLoad(object sender, EventArgs e)
        {
            // TODO: Your task goes here

        }
        private void DoTaskOnNextLeave(object sender, EventArgs e)
        {
            // TODO: Your task goes here
            
            WizardMap.FrmWizardContainer.ShowWorkInprogressNotification("<Progress Info >");
            WizardMap.FrmWizardContainer.HideWorkInprogressNotification();            
        }
        private void DoTaskOnBackLeave(object sender, EventArgs e)
        {

        }
        private void DoTaskOnChange(object sender, EventArgs e)
        {

        }        
        public void SetDoingLengthyOperation(bool working)
        {
            if (InvokeRequired)
            {
                UiHelperDelegate setDoingLengthyOperation = SetDoingLengthyOperation;
                object[] arguments = { working };

                Invoke(setDoingLengthyOperation, arguments);

                return;
            }

            Cursor = working ? Cursors.WaitCursor : Cursors.Default;
        }        
    }
}
