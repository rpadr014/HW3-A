namespace HW3_A
{
    partial class ellipticForm
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
            this.SuspendLayout();
            // 
            // ellipticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ellipticForm";
            this.Text = "ellipticForm";
            this.Activated += new System.EventHandler(this.ellipticForm_Activated);
            this.Deactivate += new System.EventHandler(this.ellipticForm_Deactivate);
            this.Load += new System.EventHandler(this.ellipticForm_Load);
            this.BackColorChanged += new System.EventHandler(this.ellipticForm_BackColorChanged);
            this.SizeChanged += new System.EventHandler(this.ellipticForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}