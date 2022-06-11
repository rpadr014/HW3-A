namespace HW3_A
{
    partial class mainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainMenuContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainMenuContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuContextStrip
            // 
            this.mainMenuContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem});
            this.mainMenuContextStrip.Name = "contextMenuStrip1";
            this.mainMenuContextStrip.Size = new System.Drawing.Size(168, 26);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modallyToolStripMenuItem,
            this.modelesslyToolStripMenuItem});
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences";
            // 
            // modallyToolStripMenuItem
            // 
            this.modallyToolStripMenuItem.Name = "modallyToolStripMenuItem";
            this.modallyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modallyToolStripMenuItem.Text = "Modally";
            this.modallyToolStripMenuItem.Click += new System.EventHandler(this.modallyToolStripMenuItem_Click);
            // 
            // modelesslyToolStripMenuItem
            // 
            this.modelesslyToolStripMenuItem.Name = "modelesslyToolStripMenuItem";
            this.modelesslyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modelesslyToolStripMenuItem.Text = "Modelessly";
            this.modelesslyToolStripMenuItem.Click += new System.EventHandler(this.modelesslyToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 628);
            this.ContextMenuStrip = this.mainMenuContextStrip;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "HW3-A";
            this.mainMenuContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip mainMenuContextStrip;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelesslyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

