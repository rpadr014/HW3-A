using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HE3_AControlLibrary;

namespace HW3_A
{
    public partial class mainForm : Form
    {
        List<ellipticForm> ellipticForms = new List<ellipticForm>();
        List<rectangularChild> rectangularForms = new List<rectangularChild>();
        List<CustomForm> customForms = new List<CustomForm>();

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
        private void mainForm_Load(object sender, EventArgs e)
        {
            //ToolStripManager.Merge(BaseForm.menuStripBase, this.menuStrip);
            this.closeAllRectangularChildrensToolStripMenuItem.Enabled = false;
            this.closeAllCustomChildrenToolStripMenuItem.Enabled = false;
            this.closeAllEllipticalChildrenToolStripMenuItem.Enabled = false;
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
            ToolStripManager.Merge(ellipticForm.menuStripBase, this.menuStrip);
            ellipticForm.Owner = this;
            ellipticForm.Show();
            ellipticForms.Add(ellipticForm);
            this.closeAllEllipticalChildrenToolStripMenuItem.Enabled = true;
        }

        private void openRectangularChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangularChild rectangularForm = new rectangularChild(rectangleHeight, ratio);
            ToolStripManager.Merge(rectangularForm.menuStripBase, this.menuStrip);
            rectangularForm.Owner = this;
            rectangularForm.Show();
            rectangularForms.Add(rectangularForm);
            this.closeAllRectangularChildrensToolStripMenuItem.Enabled = true;
        }

        private void openCustomChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm customForm = new CustomForm(ratio, ellipticWidth);
            ToolStripManager.Merge(customForm.menuStripBase, this.menuStrip);
            customForm.Owner = this;
            customForm.Show();
            customForms.Add(customForm);
            this.closeAllCustomChildrenToolStripMenuItem.Enabled = true;
            
        }

        private void CloseAllEllipticalChildrenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ellipticForms.ForEach(ellipticForm =>
            {
                ellipticForm.Close();
            });
            ellipticForms = new List<ellipticForm>();
            ToolStripManager.RevertMerge(this.menuStrip);
            this.closeAllEllipticalChildrenToolStripMenuItem.Enabled = false;
        }

        private void CloseAllRectangularChildrenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            rectangularForms.ForEach(rectangularForm =>
            {
                rectangularForm.Close();
            });
            rectangularForms = new List<rectangularChild>();
            ToolStripManager.RevertMerge(this.menuStrip);
            this.closeAllRectangularChildrensToolStripMenuItem.Enabled = false;
        }

        private void closeAllCustomChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customForms.ForEach(customForm =>
            {
                customForm.Close();
            });
            customForms = new List<CustomForm>();
            ToolStripManager.RevertMerge(this.menuStrip);
            this.closeAllCustomChildrenToolStripMenuItem.Enabled = false;
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

        private void enableLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.logInSkip = false;
            Properties.Settings.Default.Save();
        }

        public void focusOnElliptic(bool isFocused)
        {
            if (isFocused) this.toolStripStatusLabel.Text = "Elliptic";
            else this.toolStripStatusLabel.Text = "Waiting...";
        }
        public void focusOnRectangular(bool isFocused)
        {
            if (isFocused) this.toolStripStatusLabel.Text = "Rectangular";
            else this.toolStripStatusLabel.Text = "Waiting...";
        }
        public void focusOnCustom(bool isFocused)
        {
            if (isFocused) this.toolStripStatusLabel.Text = "Custom";
            else this.toolStripStatusLabel.Text = "Waiting...";
        }
        public void changeStatusBackgroundColor(Color color)
        {
            this.mainMenuStatusStrip.BackColor = color;
        }

    }
}
