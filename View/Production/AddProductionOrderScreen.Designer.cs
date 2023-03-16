namespace View
{
    partial class AddProductionOrderScreen
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
            components = new System.ComponentModel.Container();
            lblItem = new Label();
            cmbItems = new ComboBox();
            btnSave = new CustomButton();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            lblRequiredSupplies = new Label();
            dgvRequiredSupplies = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            itemBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequiredSupplies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(63, 30);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(62, 19);
            lblItem.TabIndex = 0;
            lblItem.Text = "Artículo";
            // 
            // cmbItems
            // 
            cmbItems.BackColor = Color.FromArgb(35, 35, 35);
            cmbItems.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbItems.ForeColor = Color.FromArgb(0, 125, 250);
            cmbItems.FormattingEnabled = true;
            cmbItems.Location = new Point(63, 52);
            cmbItems.Name = "cmbItems";
            cmbItems.Size = new Size(280, 29);
            cmbItems.TabIndex = 1;
            cmbItems.SelectedIndexChanged += cmbItem_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(25, 25, 25);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 125, 250);
            btnSave.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            btnSave.IconColor = Color.FromArgb(0, 125, 250);
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 30;
            btnSave.Location = new Point(320, 379);
            btnSave.Margin = new Padding(3, 20, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 46);
            btnSave.TabIndex = 2;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(63, 104);
            lblQuantity.Margin = new Padding(3, 20, 3, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(69, 19);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Cantidad";
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(35, 35, 35);
            nudQuantity.ForeColor = Color.FromArgb(0, 125, 250);
            nudQuantity.Location = new Point(63, 126);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 25);
            nudQuantity.TabIndex = 4;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // lblRequiredSupplies
            // 
            lblRequiredSupplies.AutoSize = true;
            lblRequiredSupplies.Location = new Point(63, 174);
            lblRequiredSupplies.Margin = new Padding(3, 20, 3, 0);
            lblRequiredSupplies.Name = "lblRequiredSupplies";
            lblRequiredSupplies.Size = new Size(140, 19);
            lblRequiredSupplies.TabIndex = 5;
            lblRequiredSupplies.Text = "Insumos requeridos";
            // 
            // dgvRequiredSupplies
            // 
            dgvRequiredSupplies.AllowUserToAddRows = false;
            dgvRequiredSupplies.AllowUserToDeleteRows = false;
            dgvRequiredSupplies.AutoGenerateColumns = false;
            dgvRequiredSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequiredSupplies.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, codeNameDataGridViewTextBoxColumn, barCodeDataGridViewTextBoxColumn, Quantity });
            dgvRequiredSupplies.DataSource = itemBindingSource;
            dgvRequiredSupplies.Location = new Point(63, 196);
            dgvRequiredSupplies.Name = "dgvRequiredSupplies";
            dgvRequiredSupplies.ReadOnly = true;
            dgvRequiredSupplies.RowTemplate.Height = 25;
            dgvRequiredSupplies.Size = new Size(674, 160);
            dgvRequiredSupplies.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeNameDataGridViewTextBoxColumn
            // 
            codeNameDataGridViewTextBoxColumn.DataPropertyName = "CodeName";
            codeNameDataGridViewTextBoxColumn.HeaderText = "CodeName";
            codeNameDataGridViewTextBoxColumn.Name = "codeNameDataGridViewTextBoxColumn";
            codeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barCodeDataGridViewTextBoxColumn
            // 
            barCodeDataGridViewTextBoxColumn.DataPropertyName = "BarCode";
            barCodeDataGridViewTextBoxColumn.HeaderText = "BarCode";
            barCodeDataGridViewTextBoxColumn.Name = "barCodeDataGridViewTextBoxColumn";
            barCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "ID";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Entities.Item);
            // 
            // AddProductionOrderScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRequiredSupplies);
            Controls.Add(lblRequiredSupplies);
            Controls.Add(nudQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(btnSave);
            Controls.Add(cmbItems);
            Controls.Add(lblItem);
            Name = "AddProductionOrderScreen";
            Text = "AddProductionOrderScreen";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequiredSupplies).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItem;
        private ComboBox cmbItems;
        private CustomButton btnSave;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Label lblRequiredSupplies;
        private DataGridView dgvRequiredSupplies;
        private BindingSource itemBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Quantity;
    }
}