namespace HE3_AControlLibrary
{
    partial class BaseForm
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.preferencesMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fileMenuItem.Text = "File";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // preferencesMenuItem
            // 
            this.preferencesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorMenuItem});
            this.preferencesMenuItem.Name = "preferencesMenuItem";
            this.preferencesMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesMenuItem.Text = "Preferences";
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorMenuItem.Text = "Color";
            this.colorMenuItem.Click += new System.EventHandler(this.colorMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenu;
            this.Name = "BaseForm";
            this.Text = "Base Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseForm_MouseUp);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
    }
}