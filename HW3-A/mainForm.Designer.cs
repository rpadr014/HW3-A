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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllRectangularChildrensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllEllipticalChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1592, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticChildToolStripMenuItem,
            this.openRectangularChildToolStripMenuItem,
            this.closeAllRectangularChildrensToolStripMenuItem,
            this.closeAllEllipticalChildrenToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // openEllipticChildToolStripMenuItem
            // 
            this.openEllipticChildToolStripMenuItem.Name = "openEllipticChildToolStripMenuItem";
            this.openEllipticChildToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.openEllipticChildToolStripMenuItem.Text = "Open Elliptic Child";
            // 
            // openRectangularChildToolStripMenuItem
            // 
            this.openRectangularChildToolStripMenuItem.Name = "openRectangularChildToolStripMenuItem";
            this.openRectangularChildToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.openRectangularChildToolStripMenuItem.Text = "Open Rectangular Child";
            // 
            // closeAllRectangularChildrensToolStripMenuItem
            // 
            this.closeAllRectangularChildrensToolStripMenuItem.Name = "closeAllRectangularChildrensToolStripMenuItem";
            this.closeAllRectangularChildrensToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.closeAllRectangularChildrensToolStripMenuItem.Text = "Close All Rectangular Children";
            // 
            // closeAllEllipticalChildrenToolStripMenuItem
            // 
            this.closeAllEllipticalChildrenToolStripMenuItem.Name = "closeAllEllipticalChildrenToolStripMenuItem";
            this.closeAllEllipticalChildrenToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.closeAllEllipticalChildrenToolStripMenuItem.Text = "Close All Elliptical Children";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(349, 34);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // openPreferencesToolStripMenuItem
            // 
            this.openPreferencesToolStripMenuItem.Name = "openPreferencesToolStripMenuItem";
            this.openPreferencesToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.openPreferencesToolStripMenuItem.Text = "Open Preferences ";
            // 
            // modallyToolStripMenuItem
            // 
            this.modallyToolStripMenuItem.Name = "modallyToolStripMenuItem";
            this.modallyToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.modallyToolStripMenuItem.Text = "Modally";
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            // 
            // openPreferencesToolStripMenuItem1
            // 
            this.openPreferencesToolStripMenuItem1.Name = "openPreferencesToolStripMenuItem1";
            this.openPreferencesToolStripMenuItem1.Size = new System.Drawing.Size(292, 32);
            this.openPreferencesToolStripMenuItem1.Text = "Open Preferences ";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.mToolStripMenuItem.Text = "M";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 966);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "HW3-A";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEllipticChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRectangularChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllRectangularChildrensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllEllipticalChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
    }
}

