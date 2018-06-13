using System;
using System.Windows.Forms;

namespace homiepure.wizard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start Application
            // FrmWizardContainer constructor takes WizardMap
            // WizardMap contains all wizard pages, with their whole properties initialized
            Application.Run(new FrmWizardContainer(StartUp.WizInit()));
        }
    }
}
