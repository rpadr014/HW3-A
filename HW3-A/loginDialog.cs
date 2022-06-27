using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_A
{
    public partial class loginDialog : Form
    {
        public loginDialog()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void skipLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (skipLogin.CheckState == CheckState.Checked)
            {
                Properties.Settings.Default.logInSkip = true;
                Properties.Settings.Default.Save();
            }

        }
    }
}
