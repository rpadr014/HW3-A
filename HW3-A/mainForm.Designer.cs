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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preferencesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.nameControl = new HE3_AControlLibrary.NameControl();
            this.courseControl = new HE3_AControlLibrary.CourseControl();
            this.mainMidPanel = new System.Windows.Forms.Panel();
            this.contextMenu.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesTool});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(136, 26);
            // 
            // preferencesTool
            // 
            this.preferencesTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTool});
            this.preferencesTool.Name = "preferencesTool";
            this.preferencesTool.Size = new System.Drawing.Size(135, 22);
            this.preferencesTool.Text = "Preferences";
            // 
            // colorTool
            // 
            this.colorTool.Name = "colorTool";
            this.colorTool.Size = new System.Drawing.Size(180, 22);
            this.colorTool.Text = "Color";
            this.colorTool.Click += new System.EventHandler(this.colorToolMenuItem_Click);
            // 
            // controlGroup
            // 
            this.controlGroup.BackColor = System.Drawing.Color.MistyRose;
            this.controlGroup.Controls.Add(this.mainMidPanel);
            this.controlGroup.Controls.Add(this.courseControl);
            this.controlGroup.Controls.Add(this.nameControl);
            this.controlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlGroup.Location = new System.Drawing.Point(0, 0);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(1061, 628);
            this.controlGroup.TabIndex = 1;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "group box";
            // 
            // nameControl
            // 
            this.nameControl.BackColor = System.Drawing.Color.Azure;
            this.nameControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameControl.ForeColor = System.Drawing.Color.Black;
            this.nameControl.Location = new System.Drawing.Point(3, 457);
            this.nameControl.Name = "nameControl";
            this.nameControl.Size = new System.Drawing.Size(1055, 168);
            this.nameControl.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.Location = new System.Drawing.Point(3, 16);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(1055, 57);
            this.courseControl.TabIndex = 1;
            // 
            // mainMidPanel
            // 
            this.mainMidPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMidPanel.Location = new System.Drawing.Point(3, 73);
            this.mainMidPanel.Name = "mainMidPanel";
            this.mainMidPanel.Size = new System.Drawing.Size(1055, 384);
            this.mainMidPanel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 628);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.controlGroup);
            this.Name = "mainForm";
            this.Text = "HW3-A";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.contextMenu.ResumeLayout(false);
            this.controlGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesTool;
        private System.Windows.Forms.ToolStripMenuItem colorTool;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.Panel mainMidPanel;
        private HE3_AControlLibrary.CourseControl courseControl;
        private HE3_AControlLibrary.NameControl nameControl;
    }
}

