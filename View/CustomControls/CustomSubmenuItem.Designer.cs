﻿namespace View
{
    partial class CustomSubmenuItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSize = 20;
            this.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Name = "submenu";
            this.Size = new System.Drawing.Size(238, 26);
            this.Text = "submenu";
        }

        #endregion
    }
}
