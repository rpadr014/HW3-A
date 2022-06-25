namespace HW3_A
{
    partial class CustomForm
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
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.CustomForm_Activated);
            this.Deactivate += new System.EventHandler(this.CustomForm_Deactivate);
            this.Load += new System.EventHandler(this.CustomForm_Load);
            this.BackColorChanged += new System.EventHandler(this.CustomForm_BackColorChanged);
            this.SizeChanged += new System.EventHandler(this.CustomForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}