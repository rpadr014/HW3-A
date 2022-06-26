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
    public partial class CustomForm : HE3_AControlLibrary.BaseForm
    {
        public float cRatio { get; set; }
        public int cWidth { get; set; }
        public int cHeight { get; set; }

        public CustomForm()
        {
            InitializeComponent();
        }

        public CustomForm(float customRatio, int customHeight)
        {
            cRatio = customRatio;
            cHeight = customHeight;
            cWidth = (int)(cHeight * cRatio);

            InitializeComponent();
        }

        void SetCustomRegion()
        {
            this.ClientSize = new System.Drawing.Size(cWidth, Convert.ToInt32(cHeight));
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                path.AddRectangle(rect);
                this.Region = new Region(path);
            }
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            SetCustomRegion();
        }

        private void CustomForm_SizeChanged(object sender, EventArgs e)
        {
            SetCustomRegion();
        }

        private void CustomForm_Activated(object sender, EventArgs e)
        {
            mainForm owner = (mainForm)this.Owner;
            owner.changeStatusBackgroundColor(this.BackColor);
            owner.focusOnCustom(true);
        }

        private void CustomForm_Deactivate(object sender, EventArgs e)
        {
            mainForm owner = (mainForm)this.Owner;
            owner.changeStatusBackgroundColor(Color.White);
            owner.focusOnCustom(false);
        }

        private void CustomForm_BackColorChanged(object sender, EventArgs e)
        {
            mainForm owner = (mainForm)this.Owner;
            owner.changeStatusBackgroundColor(this.BackColor);

        }
    }
}
