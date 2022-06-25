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
    public partial class rectangularChild : HE3_AControlLibrary.BaseForm
    {
        public int Rectangleheight { get; set; }
        public float Rectanglewidth { get; set; }
        public float RectangleRatio { get; set; }

        public rectangularChild()
        {
            InitializeComponent();
        }

        public rectangularChild(int rectHeight, float rectRatio)
        {
            Rectangleheight = rectHeight;
            RectangleRatio = rectRatio;
            Rectanglewidth = (float)Rectangleheight * RectangleRatio;
            InitializeComponent();
        }

        public void SetRectangleRegion()
        {
            this.ClientSize = new System.Drawing.Size(Convert.ToInt32(Rectanglewidth), Rectangleheight);
            Rectangle rect = new Rectangle(0, 0, (int)Rectanglewidth, Rectangleheight);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(rect);
                this.Region = new Region(path);
            }
        }

        private void rectangularChild_Load(object sender, EventArgs e)
        {
            SetRectangleRegion();
        }

        private void rectangularchild_SizeChanged(object sender, EventArgs e)
        {
            SetRectangleRegion();
        }

        private void rectangularChild_Activated(object sender, EventArgs e)
        {
            mainForm owner = (mainForm)this.Owner;
            owner.changeStatusBackgroundColor(this.BackColor);
            owner.focusOnRectangular(true);
        }

        private void rectangularChild_Deactivate(object sender, EventArgs e)
        {
            mainForm owner = (mainForm)this.Owner;
            owner.changeStatusBackgroundColor(Color.White);
            owner.focusOnRectangular(false);
        }

        private void rectangularChild_BackColorChanged(object sender, EventArgs e)
        {
            mainForm owner = (mainForm)this.Owner;
            owner.changeStatusBackgroundColor(this.BackColor);
        }
    }
}
