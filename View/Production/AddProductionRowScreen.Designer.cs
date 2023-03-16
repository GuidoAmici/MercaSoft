namespace View
{
    partial class AddProductionRowScreen
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
            lblItem = new Label();
            cmbItem = new ComboBox();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(63, 30);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(71, 19);
            lblItem.TabIndex = 0;
            lblItem.Text = "Producto";
            // 
            // cmbItem
            // 
            cmbItem.BackColor = Color.FromArgb(35, 35, 35);
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(63, 52);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(280, 25);
            cmbItem.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(35, 35, 35);
            nudQuantity.ForeColor = Color.FromArgb(0, 125, 250);
            nudQuantity.Location = new Point(63, 122);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(137, 25);
            nudQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(63, 100);
            lblQuantity.Margin = new Padding(3, 20, 3, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(137, 19);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad fabricada";
            // 
            // AddProductionRowScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQuantity);
            Controls.Add(nudQuantity);
            Controls.Add(cmbItem);
            Controls.Add(lblItem);
            Name = "AddProductionRowScreen";
            Text = "AddProductionRow";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItem;
        private ComboBox cmbItem;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
    }
}