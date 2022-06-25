﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using HE3_AControlLibrary;

namespace HW3_A
{
    partial class oathDialog
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
            this.oathControl = new HE3_AControlLibrary.OathControl();
            this.SuspendLayout();
            // 
            // oathControl
            // 
            this.oathControl.BackColor = System.Drawing.Color.Transparent;
            this.oathControl.Location = new System.Drawing.Point(0, 0);
            this.oathControl.Name = "oathControl";
            this.oathControl.Size = new System.Drawing.Size(866, 490);
            this.oathControl.TabIndex = 0;
            // 
            // oathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW3_A.Properties.Resources.headphones;
            this.ClientSize = new System.Drawing.Size(866, 490);
            this.Controls.Add(this.oathControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oathDialog";
            this.ShowIcon = false;
            this.Text = "OathDialog";
            this.Load += new System.EventHandler(this.oathDialog_Load);
            this.Controls.SetChildIndex(this.oathControl, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HE3_AControlLibrary.OathControl oathControl;
    }
}