namespace HE3_AControlLibrary
{
    partial class baseDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameControl1 = new HE3_AControlLibrary.NameControl();
            this.courseControl1 = new HE3_AControlLibrary.CourseControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nameControl1
            // 
            this.nameControl1.BackColor = System.Drawing.Color.Azure;
            this.nameControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameControl1.ForeColor = System.Drawing.Color.Black;
            this.nameControl1.Location = new System.Drawing.Point(0, 276);
            this.nameControl1.Name = "nameControl1";
            this.nameControl1.Size = new System.Drawing.Size(800, 174);
            this.nameControl1.TabIndex = 0;
            // 
            // courseControl1
            // 
            this.courseControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl1.Location = new System.Drawing.Point(0, 0);
            this.courseControl1.Name = "courseControl1";
            this.courseControl1.Size = new System.Drawing.Size(800, 57);
            this.courseControl1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 219);
            this.panel1.TabIndex = 2;
            // 
            // baseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.courseControl1);
            this.Controls.Add(this.nameControl1);
            this.Name = "baseDialog";
            this.Text = "Base Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private NameControl nameControl1;
        private CourseControl courseControl1;
        private System.Windows.Forms.Panel panel1;
    }
}