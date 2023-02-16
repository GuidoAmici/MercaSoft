namespace View
{
    partial class AddInvoiceScreen
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
            this.txtSubtotal = new View.CustomTextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblClients = new System.Windows.Forms.Label();
            this.txtTaxes = new View.CustomTextBox();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.btnSave = new View.CustomButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new View.CustomTextBox();
            this.txtInvoiceNumber = new View.CustomTextBox();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalWithoutTaxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalWithTaxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddItem = new View.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AcceptsReturn = true;
            this.txtSubtotal.AcceptsTab = true;
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtSubtotal.Location = new System.Drawing.Point(63, 325);
            this.txtSubtotal.MaxLength = 50;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(180, 39);
            this.txtSubtotal.TabIndex = 2;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Location = new System.Drawing.Point(63, 303);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(65, 19);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(440, 31);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(97, 19);
            this.lblInvoiceNumber.TabIndex = 5;
            this.lblInvoiceNumber.Text = "N° de factura";
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.BackColor = System.Drawing.Color.Transparent;
            this.lblClients.ForeColor = System.Drawing.Color.White;
            this.lblClients.Location = new System.Drawing.Point(63, 30);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(55, 19);
            this.lblClients.TabIndex = 9;
            this.lblClients.Text = "Cliente";
            // 
            // txtTaxes
            // 
            this.txtTaxes.AcceptsReturn = true;
            this.txtTaxes.AcceptsTab = true;
            this.txtTaxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxes.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtTaxes.Location = new System.Drawing.Point(304, 325);
            this.txtTaxes.MaxLength = 50;
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(180, 39);
            this.txtTaxes.TabIndex = 8;
            this.txtTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTaxes
            // 
            this.lblTaxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxes.Location = new System.Drawing.Point(304, 303);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(77, 19);
            this.lblTaxes.TabIndex = 9;
            this.lblTaxes.Text = "Impuestos";
            // 
            // cmbClients
            // 
            this.cmbClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClients.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(63, 52);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(279, 40);
            this.cmbClients.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(312, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 46);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(540, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 19);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.AcceptsReturn = true;
            this.txtTotal.AcceptsTab = true;
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtTotal.Location = new System.Drawing.Point(540, 325);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 39);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.AcceptsReturn = true;
            this.txtInvoiceNumber.AcceptsTab = true;
            this.txtInvoiceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInvoiceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtInvoiceNumber.Location = new System.Drawing.Point(440, 53);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(280, 39);
            this.txtInvoiceNumber.TabIndex = 14;
            this.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AutoGenerateColumns = false;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.subtotalWithoutTaxesDataGridViewTextBoxColumn,
            this.taxesDataGridViewTextBoxColumn,
            this.subtotalWithTaxesDataGridViewTextBoxColumn});
            this.dgvInvoiceItems.DataSource = this.invoiceItemBindingSource;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(63, 181);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowTemplate.Height = 25;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(657, 107);
            this.dgvInvoiceItems.TabIndex = 15;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalWithoutTaxesDataGridViewTextBoxColumn
            // 
            this.subtotalWithoutTaxesDataGridViewTextBoxColumn.DataPropertyName = "SubtotalWithoutTaxes";
            this.subtotalWithoutTaxesDataGridViewTextBoxColumn.HeaderText = "SubtotalWithoutTaxes";
            this.subtotalWithoutTaxesDataGridViewTextBoxColumn.Name = "subtotalWithoutTaxesDataGridViewTextBoxColumn";
            this.subtotalWithoutTaxesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxesDataGridViewTextBoxColumn
            // 
            this.taxesDataGridViewTextBoxColumn.DataPropertyName = "Taxes";
            this.taxesDataGridViewTextBoxColumn.HeaderText = "Taxes";
            this.taxesDataGridViewTextBoxColumn.Name = "taxesDataGridViewTextBoxColumn";
            this.taxesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalWithTaxesDataGridViewTextBoxColumn
            // 
            this.subtotalWithTaxesDataGridViewTextBoxColumn.DataPropertyName = "SubtotalWithTaxes";
            this.subtotalWithTaxesDataGridViewTextBoxColumn.HeaderText = "SubtotalWithTaxes";
            this.subtotalWithTaxesDataGridViewTextBoxColumn.Name = "subtotalWithTaxesDataGridViewTextBoxColumn";
            this.subtotalWithTaxesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceItemBindingSource
            // 
            this.invoiceItemBindingSource.DataSource = typeof(Entities.InvoiceItem);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.ForeColor = System.Drawing.Color.White;
            this.lblItem.Location = new System.Drawing.Point(63, 113);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(62, 19);
            this.lblItem.TabIndex = 16;
            this.lblItem.Text = "Artículo";
            // 
            // cmbItems
            // 
            this.cmbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItems.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(63, 135);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(409, 40);
            this.cmbItems.TabIndex = 17;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.nudQuantity.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.nudQuantity.Location = new System.Drawing.Point(503, 135);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(79, 39);
            this.nudQuantity.TabIndex = 18;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(503, 113);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Cantidad";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnAddItem.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnAddItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddItem.IconSize = 30;
            this.btnAddItem.Location = new System.Drawing.Point(611, 135);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(109, 40);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // AddInvoiceScreen
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSave);
            this.Name = "AddInvoiceScreen";
            this.Text = "Agregar nueva factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblClients;
        private ComboBox cmbClients;
        private Label lblInvoiceNumber;
        private Label lblSubtotal;
        private CustomTextBox txtSubtotal;
        private Label lblTaxes;
        private CustomTextBox txtTaxes;
        private Label lblTotal;
        private CustomTextBox txtTotal;
        private CustomButton btnSave;
        private CustomTextBox txtInvoiceNumber;
        private DataGridView dgvInvoiceItems;
        private DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalWithoutTaxesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalWithTaxesDataGridViewTextBoxColumn;
        private BindingSource invoiceItemBindingSource;
        private Label lblItem;
        private ComboBox cmbItems;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private CustomButton btnAddItem;
    }
}