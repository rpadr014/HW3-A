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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEllipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllRectangularChildrensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllEllipticalChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableLogInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openCustomChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllCustomChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.mainMenuContextStrip.SuspendLayout();
            this.mainMenuStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(707, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEllipticChildToolStripMenuItem,
            this.openRectangularChildToolStripMenuItem,
            this.openCustomChildToolStripMenuItem,
            this.closeAllRectangularChildrensToolStripMenuItem,
            this.closeAllEllipticalChildrenToolStripMenuItem,
            this.closeAllCustomChildrenToolStripMenuItem,
            this.closeApplicationToolStripMenuItem,
            this.enableLogInToolStripMenuItem});
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
            this.closeAllRectangularChildrensToolStripMenuItem.Click += new System.EventHandler(this.CloseAllRectangularChildrenToolStripMenuItem_Click);
            // 
            // closeAllEllipticalChildrenToolStripMenuItem
            // 
            this.closeAllEllipticalChildrenToolStripMenuItem.Name = "closeAllEllipticalChildrenToolStripMenuItem";
            this.closeAllEllipticalChildrenToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeAllEllipticalChildrenToolStripMenuItem.Text = "Close All Elliptical Children";
            this.closeAllEllipticalChildrenToolStripMenuItem.Click += new System.EventHandler(this.CloseAllEllipticalChildrenToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.CloseApplicationToolStripMenuItem_Click);
            // 
            // enableLogInToolStripMenuItem
            // 
            this.enableLogInToolStripMenuItem.Name = "enableLogInToolStripMenuItem";
            this.enableLogInToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.enableLogInToolStripMenuItem.Text = "Enable Log In";
            this.enableLogInToolStripMenuItem.Click += new System.EventHandler(this.enableLogInToolStripMenuItem_Click);
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
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.mToolStripMenuItem.Text = "M";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += OathToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainMenuStatusStrip
            // 
            this.mainMenuStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.mainMenuStatusStrip.Location = new System.Drawing.Point(0, 386);
            this.mainMenuStatusStrip.Name = "mainMenuStatusStrip";
            this.mainMenuStatusStrip.Size = new System.Drawing.Size(707, 22);
            this.mainMenuStatusStrip.TabIndex = 1;
            this.mainMenuStatusStrip.Text = "Status";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // openCustomChildToolStripMenuItem
            // 
            this.openCustomChildToolStripMenuItem.Name = "openCustomChildToolStripMenuItem";
            this.openCustomChildToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openCustomChildToolStripMenuItem.Text = "Open Custom Child";
            this.openCustomChildToolStripMenuItem.Click += new System.EventHandler(this.openCustomChildToolStripMenuItem_Click);
            // 
            // closeAllCustomChildrenToolStripMenuItem
            // 
            this.closeAllCustomChildrenToolStripMenuItem.Name = "closeAllCustomChildrenToolStripMenuItem";
            this.closeAllCustomChildrenToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.closeAllCustomChildrenToolStripMenuItem.Text = "Close All Custom Children";
            this.closeAllCustomChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllCustomChildrenToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.ContextMenuStrip = this.mainMenuContextStrip;
            this.Controls.Add(this.mainMenuStatusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "HW3-A";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainMenuContextStrip.ResumeLayout(false);
            this.mainMenuStatusStrip.ResumeLayout(false);
            this.mainMenuStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OathToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new oathDialog().ShowDialog();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.MenuStrip menuStrip;
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
        //private System.Windows.Forms.ToolStripMenuItem openPreferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mainMenuContextStrip;
        private System.Windows.Forms.ToolStripMenuItem modelesslyToolStripMenuItem;
        private ToolStripMenuItem enableLogInToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem oathToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip mainMenuStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem openCustomChildToolStripMenuItem;
        private ToolStripMenuItem closeAllCustomChildrenToolStripMenuItem;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
    }
}

