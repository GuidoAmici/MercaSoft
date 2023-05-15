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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblItem = new Label();
            cmbItems = new ComboBox();
            btnSave = new CustomButton();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            lblRequiredSupplies = new Label();
            dgvRequiredSupplies = new CustomDataGridView();
            itemBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
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
            cmbItems.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbItems.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbItems.BackColor = Color.FromArgb(35, 35, 35);
            cmbItems.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbItems.ForeColor = Color.FromArgb(0, 125, 250);
            cmbItems.FormattingEnabled = true;
            cmbItems.Location = new Point(63, 52);
            cmbItems.Name = "cmbItems";
            cmbItems.Size = new Size(492, 29);
            cmbItems.TabIndex = 1;
            cmbItems.SelectedIndexChanged += CmbItem_SelectedIndexChanged;
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
            btnSave.Click += BtnSave_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(617, 34);
            lblQuantity.Margin = new Padding(3, 20, 3, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(69, 19);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Cantidad";
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(35, 35, 35);
            nudQuantity.Enabled = false;
            nudQuantity.ForeColor = Color.FromArgb(0, 125, 250);
            nudQuantity.Location = new Point(617, 56);
            nudQuantity.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 25);
            nudQuantity.TabIndex = 4;
            nudQuantity.ThousandsSeparator = true;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += NudQuantity_ValueChanged;
            // 
            // lblRequiredSupplies
            // 
            lblRequiredSupplies.AutoSize = true;
            lblRequiredSupplies.Location = new Point(63, 104);
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
            dgvRequiredSupplies.AllowUserToResizeRows = false;
            dgvRequiredSupplies.AutoGenerateColumns = false;
            dgvRequiredSupplies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvRequiredSupplies.BackgroundColor = Color.FromArgb(35, 35, 35);
            dgvRequiredSupplies.BorderStyle = BorderStyle.Fixed3D;
            dgvRequiredSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequiredSupplies.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, codeNameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, barCodeDataGridViewTextBoxColumn, Quantity });
            dgvRequiredSupplies.DataSource = itemBindingSource;
            dgvRequiredSupplies.GridColor = SystemColors.InactiveCaptionText;
            dgvRequiredSupplies.Location = new Point(63, 126);
            dgvRequiredSupplies.Name = "dgvRequiredSupplies";
            dgvRequiredSupplies.ReadOnly = true;
            dgvRequiredSupplies.RowHeadersVisible = false;
            dgvRequiredSupplies.RowTemplate.Height = 25;
            dgvRequiredSupplies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequiredSupplies.Size = new Size(674, 230);
            dgvRequiredSupplies.TabIndex = 6;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Entities.Item);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            iDDataGridViewTextBoxColumn.Width = 48;
            // 
            // codeNameDataGridViewTextBoxColumn
            // 
            codeNameDataGridViewTextBoxColumn.DataPropertyName = "CodeName";
            codeNameDataGridViewTextBoxColumn.HeaderText = "Código";
            codeNameDataGridViewTextBoxColumn.Name = "codeNameDataGridViewTextBoxColumn";
            codeNameDataGridViewTextBoxColumn.ReadOnly = true;
            codeNameDataGridViewTextBoxColumn.Width = 83;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            stockDataGridViewTextBoxColumn.Width = 71;
            // 
            // barCodeDataGridViewTextBoxColumn
            // 
            barCodeDataGridViewTextBoxColumn.DataPropertyName = "BarCode";
            barCodeDataGridViewTextBoxColumn.HeaderText = "Código de barras";
            barCodeDataGridViewTextBoxColumn.Name = "barCodeDataGridViewTextBoxColumn";
            barCodeDataGridViewTextBoxColumn.ReadOnly = true;
            barCodeDataGridViewTextBoxColumn.Visible = false;
            barCodeDataGridViewTextBoxColumn.Width = 151;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "SuppliedQuantity";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.HeaderText = "Cant. insumos";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 126;
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
        private BindingSource itemBindingSource;
        private CustomDataGridView dgvRequiredSupplies;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Quantity;
    }
}