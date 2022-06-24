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
            this.components = new System.ComponentModel.Container();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.rText = new System.Windows.Forms.TextBox();
            this.hText = new System.Windows.Forms.TextBox();
            this.wText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.wTip = new System.Windows.Forms.ToolTip(this.components);
            this.wError = new System.Windows.Forms.ErrorProvider(this.components);
            this.hError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rError = new System.Windows.Forms.ErrorProvider(this.components);
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rError)).BeginInit();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.BackgroundImage = global::HW3_A.Properties.Resources.headphones;
            this.centerPanel.Controls.Add(this.rText);
            this.centerPanel.Controls.Add(this.hText);
            this.centerPanel.Controls.Add(this.wText);
            this.centerPanel.Controls.Add(this.cancelButton);
            this.centerPanel.Controls.Add(this.applyButton);
            this.centerPanel.Controls.Add(this.okayButton);
            this.centerPanel.Controls.Add(this.ratioLabel);
            this.centerPanel.Controls.Add(this.heightLabel);
            this.centerPanel.Controls.Add(this.widthLabel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 57);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(800, 219);
            this.centerPanel.TabIndex = 2;
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(425, 139);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(100, 20);
            this.rText.TabIndex = 14;
            this.wTip.SetToolTip(this.rText, "Range: 1 - 5");
            this.rText.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.rText_HelpRequested);
            this.rText.Validating += new System.ComponentModel.CancelEventHandler(this.rText_Validating);
            this.rText.Validated += new System.EventHandler(this.okayButton_Click);
            // 
            // hText
            // 
            this.hText.Location = new System.Drawing.Point(425, 92);
            this.hText.Name = "hText";
            this.hText.Size = new System.Drawing.Size(100, 20);
            this.hText.TabIndex = 13;
            this.wTip.SetToolTip(this.hText, "Range: 1 - 500");
            this.hText.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.hText_HelpRequested);
            this.hText.Validating += new System.ComponentModel.CancelEventHandler(this.hText_Validating);
            this.hText.Validated += new System.EventHandler(this.okayButton_Click);
            // 
            // wText
            // 
            this.wText.BackColor = System.Drawing.SystemColors.Window;
            this.wText.Location = new System.Drawing.Point(425, 41);
            this.wText.Name = "wText";
            this.wText.Size = new System.Drawing.Size(100, 20);
            this.wText.TabIndex = 12;
            this.wTip.SetToolTip(this.wText, "Range: 1 - 500");
            this.wText.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.wText_HelpRequested);
            this.wText.Validating += new System.ComponentModel.CancelEventHandler(this.wText_Validating);
            this.wText.Validated += new System.EventHandler(this.okayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(450, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.wTip.SetToolTip(this.cancelButton, "Cancel");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(356, 180);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.wTip.SetToolTip(this.applyButton, "Range(Width & Height): 1 - 500 Range(Ratio): 1 - 5");
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(262, 180);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 6;
            this.okayButton.Text = "OK";
            this.wTip.SetToolTip(this.okayButton, "Range(Width & Height): 1 - 500 Range(Ratio): 1 - 5");
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
            // wTip
            // 
            this.wTip.AutomaticDelay = 250;
            // 
            // wError
            // 
            this.wError.ContainerControl = this;
            // 
            // hError
            // 
            this.hError.ContainerControl = this;
            // 
            // rError
            // 
            this.rError.ContainerControl = this;
            // 
            // preferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.centerPanel);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preferenceForm";
            this.Text = "Preference Dialog";
            this.Activated += new System.EventHandler(this.preferenceForm_Activated);
            this.Deactivate += new System.EventHandler(this.preferenceForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.preferenceForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressEvent);
            this.Controls.SetChildIndex(this.centerPanel, 0);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label ratioLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.TextBox wText;
        private System.Windows.Forms.TextBox rText;
        private System.Windows.Forms.TextBox hText;
        private System.Windows.Forms.ToolTip wTip;
        private System.Windows.Forms.ErrorProvider wError;
        private System.Windows.Forms.ErrorProvider hError;
        private System.Windows.Forms.ErrorProvider rError;
    }
}