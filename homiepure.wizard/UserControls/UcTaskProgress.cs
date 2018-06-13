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
    public partial class UcTaskProgress : UserControl
    {
        public string StatusMessage { get; set; }

        public UcTaskProgress()
        {
            InitializeComponent();
        }

        public void DisplayStatus(string message)
        {
            //    if (InvokeRequired)
            //    {
            //        Invoke((MethodInvoker) (() =>
            //        {
            //            lcTaskStatus.Text = message;
            //        }));
            //    }
            //    else
            // {
            lcTaskStatus.Text = message;
            //   }
        }
    }
}
