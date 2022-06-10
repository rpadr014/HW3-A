﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE3_AControlLibrary
{
    public partial class baseForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public baseForm()
        {
            InitializeComponent();
        }

        private void baseForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void baseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void baseForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void contextMenu_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }
    }
}