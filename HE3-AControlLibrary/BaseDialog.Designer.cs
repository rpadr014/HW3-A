namespace HE3_AControlLibrary
{
    partial class BaseDialog
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
            this.nameControl = new HE3_AControlLibrary.NameControl();
            this.courseControl = new HE3_AControlLibrary.CourseControl();
            this.midPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nameControl
            // 
            this.nameControl.BackColor = System.Drawing.Color.Azure;
            this.nameControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameControl.ForeColor = System.Drawing.Color.Black;
            this.nameControl.Location = new System.Drawing.Point(0, 340);
            this.nameControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameControl.Name = "nameControl";
            this.nameControl.Size = new System.Drawing.Size(1067, 214);
            this.nameControl.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.Location = new System.Drawing.Point(0, 0);
            this.courseControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(1067, 70);
            this.courseControl.TabIndex = 1;
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.Transparent;
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 70);
            this.midPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1067, 270);
            this.midPanel.TabIndex = 2;
            // 
            // BaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.nameControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaseDialog";
            this.Text = "Base Dialog";
            this.Load += new System.EventHandler(this.BaseDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NameControl nameControl;
        private CourseControl courseControl;
        private System.Windows.Forms.Panel midPanel;
    }
}