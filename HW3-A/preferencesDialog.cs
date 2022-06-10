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
    public partial class preferenceForm : HE3_AControlLibrary.baseDialog
    {
        public event EventHandler Apply;
        public static int rHeight { get; set;}
        public static int eWidth { get; set; }
        public static float ratio { get; set; }

        public preferenceForm()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (Apply != null)
            {
                rHeight = Convert.ToInt32(Math.Round(hNum.Value, 0));
                eWidth = Convert.ToInt32(Math.Round(wNum.Value, 0));
                ratio = (float)rNum.Value;
                Apply(this, EventArgs.Empty);
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
