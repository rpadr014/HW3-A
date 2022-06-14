using System.Windows.Forms;

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
            this.openEllipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllRectangularChildrensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllEllipticalChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainMenuContextStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openEllipticChildToolStripMenuItem
            // 
            this.openEllipticChildToolStripMenuItem.Name = "openEllipticChildToolStripMenuItem";
            this.openEllipticChildToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openEllipticChildToolStripMenuItem.Text = "Open Elliptic Child";
            this.openEllipticChildToolStripMenuItem.Click += new System.EventHandler(this.openEllipticChildToolStripMenuItem_Click);
            // 
            // openRectangularChildToolStripMenuItem
            // 
            this.openRectangularChildToolStripMenuItem.Name = "openRectangularChildToolStripMenuItem";
            this.openRectangularChildToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openRectangularChildToolStripMenuItem.Text = "Open Rectangular Child";
            this.openRectangularChildToolStripMenuItem.Click += new System.EventHandler(this.openRectangularChildToolStripMenuItem_Click);
            // 
            // closeAllRectangularChildrensToolStripMenuItem
            // 
            this.closeAllRectangularChildrensToolStripMenuItem.Name = "closeAllRectangularChildrensToolStripMenuItem";
            this.closeAllRectangularChildrensToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeAllRectangularChildrensToolStripMenuItem.Text = "Close All Rectangular Children";
            // 
            // closeAllEllipticalChildrenToolStripMenuItem
            // 
            this.closeAllEllipticalChildrenToolStripMenuItem.Name = "closeAllEllipticalChildrenToolStripMenuItem";
            this.closeAllEllipticalChildrenToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeAllEllipticalChildrenToolStripMenuItem.Text = "Close All Elliptical Children";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDown = this.mainMenuContextStrip;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // mainMenuContextStrip
            // 
            this.mainMenuContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesToolStripMenuItem});
            this.mainMenuContextStrip.Name = "contextMenuStrip1";
            this.mainMenuContextStrip.OwnerItem = this.preferencesToolStripMenuItem;
            this.mainMenuContextStrip.Size = new System.Drawing.Size(171, 26);
            // 
            // openPreferencesToolStripMenuItem
            // 
            this.openPreferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modallyToolStripMenuItem,
            this.modelesslyToolStripMenuItem});
            this.openPreferencesToolStripMenuItem.Name = "openPreferencesToolStripMenuItem";
            this.openPreferencesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openPreferencesToolStripMenuItem.Text = "Open Preferences ";
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
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            // 
            // openPreferencesToolStripMenuItem1
            // 
            this.openPreferencesToolStripMenuItem1.Name = "openPreferencesToolStripMenuItem1";
            this.openPreferencesToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.mToolStripMenuItem.Text = "M";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.ContextMenuStrip = this.mainMenuContextStrip;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "HW3-A";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainMenuContextStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip mainMenuContextStrip;
        private System.Windows.Forms.ToolStripMenuItem modelesslyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

