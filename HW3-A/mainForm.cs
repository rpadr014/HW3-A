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
        private int rectangleHeight;
        private int ellipticWidth;
        private float ratio;
        public mainForm()
        {
            InitializeComponent();

            preferenceForm preferenceForm = new preferenceForm();
            preferenceForm.Apply += PreferenceForm_Apply;
            preferenceForm.Show();
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

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
