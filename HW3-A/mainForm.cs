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
        private bool mouseDown;
        private Point lastLocation;
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

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void colorToolMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }
    }
}
