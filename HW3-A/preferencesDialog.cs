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
    public partial class preferenceForm : HE3_AControlLibrary.BaseDialog
    {
        public event EventHandler Apply;
        public static int rHeight { get; set; }
        public static int eWidth { get; set; }
        public static float ratio { get; set; }

        private static mainForm mainFormInstance;

        public preferenceForm()
        {
            InitializeComponent();
        }

        public preferenceForm(mainForm callingForm)
        {
            mainFormInstance = callingForm;
            rHeight = mainFormInstance.rectangleHeight;
            eWidth = mainFormInstance.ellipticWidth;
            ratio = mainFormInstance.ratio;
            InitializeComponent();
            rHeight = 100;
            eWidth = 100;
            ratio = 1;
            rText.Text = "1";
            wText.Text = "250";
            hText.Text = "250";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            mainFormInstance.updateFormUserValues(rHeight, eWidth, ratio);
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            mainFormInstance.updateFormUserValues(rHeight, eWidth, ratio);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainFormInstance.updateFormUserValues(rHeight, eWidth, ratio);
            this.Close();
        }

        public void hideApplyButton()
        {
            this.applyButton.Visible = true;
        }

        private void preferenceForm_FormClosing(object sender, FormClosingEventArgs e)
        {

                if (e.CloseReason == CloseReason.UserClosing)
                {
                    mainFormInstance.updateFormUserValues(rHeight, eWidth, ratio);
                }

        }

        private void KeyPressEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X || e.KeyCode == Keys.Escape)
            {
                mainFormInstance.updateFormUserValues(rHeight, eWidth, ratio);
                this.Close();
            }
       }

        private void wText_Validating(object sender, CancelEventArgs e)
        {
            eWidth = (wText.Text.Length == 0) ? 0 : int.Parse(wText.Text);

            if (eWidth > 500 || eWidth < 1)
            {
                //MessageBox.Show("Not in range.");
                e.Cancel = true;
                wError.SetError(wText,"Not in range");
            } else
            {
                wError.Clear();
            }
        }

        private void hText_Validating(object sender, CancelEventArgs e)
        {
            rHeight = (hText.Text.Length == 0) ? 0 : int.Parse(hText.Text);

            if (rHeight > 500 || rHeight < 1)
            {
                //MessageBox.Show("Not in range.");
                e.Cancel = true;
                hError.SetError(hText,"Not in range");
            } else
            {
                hError.Clear();
            }
        }

        private void rText_Validating(object sender, CancelEventArgs e)
        {
            ratio = (rText.Text.Length == 0) ? 0 : float.Parse(rText.Text);

            if (ratio > 5 || ratio < 1)
            {
                //MessageBox.Show("Not in range.");
                e.Cancel = true;
                rError.SetError(rText, "Not in range");
            } else
            {
                rError.Clear();
            }
        }

        private void wText_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Range is from 1 to 500");
        }

        private void hText_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Range is from 1 to 500");
        }

        private void rText_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Range is from 1 to 5");
        }

        private void preferenceForm_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = (double)0.50;
            }
            catch (Exception err)
            {
                //MessageBox.Show(this,err.ToString());
            }
        }

        private void preferenceForm_Activated(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = (double)1.0;
            }
            catch (Exception err)
            {
                //MessageBox.Show(this, err.ToString());
            }
        }

        private void preferenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Close using Okay/Cancel");
            mainFormInstance.updatePrefStatus();
        }

        private void preferenceForm_Load(object sender, EventArgs e)
        {
            mainFormInstance.updatePrefStatus();
        }
    }
}
