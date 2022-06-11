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
            this.mainMenuContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainMenuContextStrip.SuspendLayout();
            this.SuspendLayout();

            this.FormClosing += MainForm_FormClosing;

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
            this.closeApplicationToolStripMenuItem.Click += CloseApplicationToolStripMenuItem_Click;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 966);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientSize = new System.Drawing.Size(1061, 628);
            this.ContextMenuStrip = this.mainMenuContextStrip;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "HW3-A";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainMenuContextStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CloseApplicationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(
                "Close the application?",
                "Are you sure?",
                MessageBoxButtons.YesNo);
            this.PerformLayout();

            if(res == DialogResult.No)
            {
                e.Cancel = true;
            }
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

