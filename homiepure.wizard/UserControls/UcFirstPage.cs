using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homiepure.wizard.UserControls
{
    public partial class UcFirstPage : WizardPage
    {
        public WizardMap.PageDoTask DoTaskHandler = DoTask;


        public UcFirstPage()
        {
            InitializeComponent();

            DoTaskOnNextLeaveEventHandler += DoTaskOnNextLeave;
            DoTaskOnBackLeaveEventHandler += DoTaskOnBackLeave;
            DoTaskOnLoadEventHandler += DoTaskOnLoad;
            DoTaskOnChangeEventHandler += DoTaskOnChange;
        }

        public static void DoTask(object sender)
        {

        }
        private void DoTaskOnLoad(object sender, EventArgs e)
        {

        }
        private void DoTaskOnNextLeave(object sender, EventArgs e)
        {

        }
        private void DoTaskOnBackLeave(object sender, EventArgs e)
        {

        }
        private void DoTaskOnChange(object sender, EventArgs e)
        {

        }
    }
}
