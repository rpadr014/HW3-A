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
            hNum.Value = rHeight;
            wNum.Value = eWidth;
            rNum.Value = (decimal)ratio;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            mainFormInstance.updateFormUserValues(Convert.ToInt32(Math.Round(hNum.Value, 0)), Convert.ToInt32(Math.Round(wNum.Value, 0)), (float)rNum.Value);
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            rHeight = Convert.ToInt32(Math.Round(hNum.Value, 0));
            eWidth = Convert.ToInt32(Math.Round(wNum.Value, 0));
            ratio = (float)rNum.Value;
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
            this.applyButton.Visible = false;
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
    }
}
