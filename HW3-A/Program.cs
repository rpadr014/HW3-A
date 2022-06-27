using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_A
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.logInSkip == false)
            {
                DialogResult result;
                using (var loginDlg = new loginDialog())
                {
                    result = loginDlg.ShowDialog();
                }

                if (result == DialogResult.OK)
                {
                    System.Diagnostics.Debug.WriteLine("Send to debug output.");
                    Application.Run(new mainForm());
                }
            }
            else
            Application.Run(new mainForm());
        }
    }
}
