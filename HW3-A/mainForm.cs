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
        public int rectangleHeight { get; set; }
        public int ellipticWidth { get; set; }
        public float ratio { get; set; }
        public mainForm()
        {
            InitializeComponent();
            rectangleHeight = 1280;
            ellipticWidth = 720;
            ratio = 2;
            preferenceForm preferenceForm = createPreferenceForm();
           // ellipticForm ellipticForm = new ellipticForm(ratio, ellipticWidth);
            
            this.label1.Text = "Rectangle Height: " + rectangleHeight;
            this.label2.Text = "Elliptic Width: " + ellipticWidth;
            this.label3.Text = "Ratio: " + ratio;
            preferenceForm.Show();
            //ellipticForm.Show();
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
            this.label1.Text = "Rectangle Height: " + rectangleHeight;
            this.label2.Text = "Elliptic Width: " + ellipticWidth;
            this.label3.Text = "Ratio: " + ratio;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openEllipticChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ellipticForm ellipticForm = new ellipticForm(ratio, ellipticWidth);
            ellipticForm.Show();
        }
    }
}
