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
            lblProductionOrder = new Label();
            cmbItem = new ComboBox();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            customDataGridView1 = new CustomDataGridView();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblProductionOrder
            // 
            lblProductionOrder.AutoSize = true;
            lblProductionOrder.Location = new Point(63, 30);
            lblProductionOrder.Name = "lblProductionOrder";
            lblProductionOrder.Size = new Size(152, 19);
            lblProductionOrder.TabIndex = 0;
            lblProductionOrder.Text = "Orden de Producción";
            // 
            // cmbItem
            // 
            cmbItem.BackColor = Color.FromArgb(35, 35, 35);
            cmbItem.ForeColor = Color.FromArgb(0, 125, 250);
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(63, 52);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(465, 25);
            cmbItem.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(35, 35, 35);
            nudQuantity.ForeColor = Color.FromArgb(0, 125, 250);
            nudQuantity.Location = new Point(600, 52);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(137, 25);
            nudQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(600, 29);
            lblQuantity.Margin = new Padding(3, 20, 3, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(137, 19);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad fabricada";
            // 
            // customDataGridView1
            // 
            customDataGridView1.AllowUserToAddRows = false;
            customDataGridView1.AllowUserToDeleteRows = false;
            customDataGridView1.AllowUserToResizeRows = false;
            customDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            customDataGridView1.BackgroundColor = Color.FromArgb(35, 35, 35);
            customDataGridView1.BorderStyle = BorderStyle.Fixed3D;
            customDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customDataGridView1.GridColor = SystemColors.InactiveCaptionText;
            customDataGridView1.Location = new Point(63, 124);
            customDataGridView1.Name = "customDataGridView1";
            customDataGridView1.ReadOnly = true;
            customDataGridView1.RowHeadersVisible = false;
            customDataGridView1.RowTemplate.Height = 25;
            customDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView1.Size = new Size(674, 293);
            customDataGridView1.TabIndex = 4;
            // 
            // AddProductionRowScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customDataGridView1);
            Controls.Add(lblQuantity);
            Controls.Add(nudQuantity);
            Controls.Add(cmbItem);
            Controls.Add(lblProductionOrder);
            Name = "AddProductionRowScreen";
            Text = "AddProductionRow";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductionOrder;
        private ComboBox cmbItem;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private CustomDataGridView customDataGridView1;
    }
}