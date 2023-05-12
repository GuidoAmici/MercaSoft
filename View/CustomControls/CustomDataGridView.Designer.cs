using System.Windows.Forms;

namespace View
{
    partial class CustomDataGridView
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
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AutoGenerateColumns = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.BackgroundColor = Color.FromArgb(35, 35, 35);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ForeColor = Color.Black;
            this.GridColor = SystemColors.InactiveCaptionText;
            this.Location = new Point(63, 196);
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 25;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion
    }
}
