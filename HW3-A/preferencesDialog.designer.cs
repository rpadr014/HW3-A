namespace HW3_A
{
    partial class preferenceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rNum = new System.Windows.Forms.NumericUpDown();
            this.hNum = new System.Windows.Forms.NumericUpDown();
            this.wNum = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rNum);
            this.panel1.Controls.Add(this.hNum);
            this.panel1.Controls.Add(this.wNum);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Controls.Add(this.okayButton);
            this.panel1.Controls.Add(this.ratioLabel);
            this.panel1.Controls.Add(this.heightLabel);
            this.panel1.Controls.Add(this.widthLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 219);
            this.panel1.TabIndex = 2;
            // 
            // rNum
            // 
            this.rNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.rNum.Location = new System.Drawing.Point(404, 139);
            this.rNum.Name = "rNum";
            this.rNum.Size = new System.Drawing.Size(120, 20);
            this.rNum.TabIndex = 11;
            // 
            // hNum
            // 
            this.hNum.Location = new System.Drawing.Point(405, 88);
            this.hNum.Name = "hNum";
            this.hNum.Size = new System.Drawing.Size(120, 20);
            this.hNum.TabIndex = 10;
            // 
            // wNum
            // 
            this.wNum.Location = new System.Drawing.Point(405, 41);
            this.wNum.Name = "wNum";
            this.wNum.Size = new System.Drawing.Size(120, 20);
            this.wNum.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(450, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(356, 180);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(262, 180);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 6;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // ratioLabel
            // 
            this.ratioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratioLabel.AutoSize = true;
            this.ratioLabel.Location = new System.Drawing.Point(259, 139);
            this.ratioLabel.Name = "ratioLabel";
            this.ratioLabel.Size = new System.Drawing.Size(38, 13);
            this.ratioLabel.TabIndex = 2;
            this.ratioLabel.Text = "Ratio: ";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(259, 95);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(134, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height of Rectangle Child: ";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(259, 41);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(109, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width of Elliptic Child:";
            // 
            // preferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "preferenceForm";
            this.Text = "Preference Dialog";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ratioLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.NumericUpDown rNum;
        private System.Windows.Forms.NumericUpDown hNum;
        private System.Windows.Forms.NumericUpDown wNum;
    }
}