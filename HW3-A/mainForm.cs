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
    public partial class mainForm : Form
    {
        List<ellipticForm> ellipticForms = new List<ellipticForm>();
        List<rectangularChild> rectangularForms = new List<rectangularChild>();

        public int rectangleHeight { get; set; }
        public int ellipticWidth { get; set; }
        public float ratio { get; set; }
        public mainForm()
        {
            InitializeComponent();
            rectangleHeight = 250;
            ellipticWidth = 300;
            ratio = 2;
            preferenceForm preferenceForm = createPreferenceForm();
            
            this.FormClosing += MainForm_FormClosing;;
        }

        private void PreferenceForm_Apply(object sender, EventArgs e)
        {
            rectangleHeight = preferenceForm.rHeight;
            ellipticWidth = preferenceForm.eWidth;
            ratio = preferenceForm.ratio;
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferenceForm preferenceForm = createPreferenceForm();
            preferenceForm.hideApplyButton();
            preferenceForm.ShowDialog();
        }

        private void modelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferenceForm preferenceForm = createPreferenceForm();
            preferenceForm.Show();
        }

        private preferenceForm createPreferenceForm()
        {
            preferenceForm preferenceForm = new preferenceForm(this);
            preferenceForm.Apply += PreferenceForm_Apply;
            return preferenceForm;
        }

        public void updateFormUserValues(int rHeight, int eWidth, float ratio)
        {
            rectangleHeight = rHeight;
            ellipticWidth = eWidth;
            this.ratio = ratio;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openEllipticChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ellipticForm ellipticForm = new ellipticForm(ratio, ellipticWidth);
            ellipticForm.Show();
            ellipticForms.Add(ellipticForm);
        }

        private void openRectangularChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangularChild rectangularForm = new rectangularChild(rectangleHeight, ratio);
            rectangularForm.Show();
            rectangularForms.Add(rectangularForm);
        }

        private void CloseAllEllipticalChildrenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ellipticForms.ForEach(ellipticForm =>
            {
                ellipticForm.Close();
            });
            ellipticForms = new List<ellipticForm>();
        }

        private void CloseAllRectangularChildrenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            rectangularForms.ForEach(rectangularForm =>
            {
                rectangularForm.Close();
            });
            rectangularForms = new List<rectangularChild>();
        }


        private void CloseApplicationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(
                "Close the application?",
                "Are you sure?",
                MessageBoxButtons.YesNo);
            this.PerformLayout();

            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
