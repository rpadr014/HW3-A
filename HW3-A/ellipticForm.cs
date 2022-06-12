using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HW3_A
{
    public partial class ellipticForm : HE3_AControlLibrary.BaseForm
    {
        public float eRatio { get; set; }
        public int eWidth { get; set; }
        public float eHeight { get; set; }

        public ellipticForm()
        {
            InitializeComponent();
        }

        public ellipticForm(float ellipseratio, int ellipsewidth)
        {
            eRatio = ellipseratio;
            eWidth = ellipsewidth;
            eHeight = eWidth * eRatio;
            InitializeComponent();
        }

        void SetEllipseRegion()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, eWidth, eHeight);
                this.Region = new Region(path);
            }

            System.Diagnostics.Debug.WriteLine(this.Height);
            System.Diagnostics.Debug.WriteLine(this.Width);
        }

        private void ellipticForm_Load(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }

        private void ellipticForm_SizeChanged(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }
    }
}
