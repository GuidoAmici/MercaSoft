namespace View
{
    partial class AddItemScreen
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
            chkIsForSale = new CheckBox();
            txtItemName = new CustomTextBox();
            lblItemName = new Label();
            lblCodeName = new Label();
            txtCodeName = new CustomTextBox();
            lblSalePrice = new Label();
            txtSalePrice = new CustomTextBox();
            label1 = new Label();
            txtBarCode = new CustomTextBox();
            lblBarCode = new Label();
            cmbCategories = new ComboBox();
            txtDescription = new CustomTextBox();
            lblDescription = new Label();
            btnSave = new CustomButton();
            chkIsProducible = new CheckBox();
            btnAssociateSupplies = new CustomButton();
            dgvAssociatedSupplies = new CustomDataGridView();
            lblDgvAssociatedSupplies = new Label();
            cmbSupplies = new ComboBox();
            lblSupplyList = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedSupplies).BeginInit();
            SuspendLayout();
            // 
            // chkIsForSale
            // 
            chkIsForSale.Anchor = AnchorStyles.None;
            chkIsForSale.AutoSize = true;
            chkIsForSale.BackColor = Color.Transparent;
            chkIsForSale.ForeColor = Color.White;
            chkIsForSale.Location = new Point(61, 252);
            chkIsForSale.Name = "chkIsForSale";
            chkIsForSale.Size = new Size(185, 23);
            chkIsForSale.TabIndex = 5;
            chkIsForSale.Text = "¿Artículo para la venta?";
            chkIsForSale.UseVisualStyleBackColor = false;
            chkIsForSale.CheckedChanged += ChkIsForSale_CheckedChanged;
            // 
            // txtItemName
            // 
            txtItemName.AcceptsReturn = true;
            txtItemName.AcceptsTab = true;
            txtItemName.Anchor = AnchorStyles.None;
            txtItemName.BackColor = Color.FromArgb(35, 35, 35);
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.ForeColor = Color.FromArgb(0, 125, 250);
            txtItemName.Location = new Point(59, 59);
            txtItemName.MaxLength = 50;
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Obligatorio";
            txtItemName.Size = new Size(280, 29);
            txtItemName.TabIndex = 2;
            txtItemName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.None;
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(59, 37);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(145, 19);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "Nombre del artículo";
            // 
            // lblCodeName
            // 
            lblCodeName.Anchor = AnchorStyles.None;
            lblCodeName.AutoSize = true;
            lblCodeName.BackColor = Color.Transparent;
            lblCodeName.ForeColor = Color.White;
            lblCodeName.Location = new Point(436, 37);
            lblCodeName.Name = "lblCodeName";
            lblCodeName.Size = new Size(138, 19);
            lblCodeName.TabIndex = 5;
            lblCodeName.Text = "Código del artículo";
            // 
            // txtCodeName
            // 
            txtCodeName.AcceptsReturn = true;
            txtCodeName.AcceptsTab = true;
            txtCodeName.Anchor = AnchorStyles.None;
            txtCodeName.BackColor = Color.FromArgb(35, 35, 35);
            txtCodeName.BorderStyle = BorderStyle.FixedSingle;
            txtCodeName.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodeName.ForeColor = Color.FromArgb(0, 125, 250);
            txtCodeName.Location = new Point(441, 63);
            txtCodeName.MaxLength = 50;
            txtCodeName.Name = "txtCodeName";
            txtCodeName.PlaceholderText = "Opcional";
            txtCodeName.Size = new Size(280, 25);
            txtCodeName.TabIndex = 9;
            txtCodeName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSalePrice
            // 
            lblSalePrice.Anchor = AnchorStyles.None;
            lblSalePrice.AutoSize = true;
            lblSalePrice.BackColor = Color.Transparent;
            lblSalePrice.ForeColor = Color.White;
            lblSalePrice.Location = new Point(61, 284);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(114, 19);
            lblSalePrice.TabIndex = 6;
            lblSalePrice.Text = "Precio de venta";
            lblSalePrice.Visible = false;
            // 
            // txtSalePrice
            // 
            txtSalePrice.AcceptsReturn = true;
            txtSalePrice.AcceptsTab = true;
            txtSalePrice.Anchor = AnchorStyles.None;
            txtSalePrice.BackColor = Color.FromArgb(35, 35, 35);
            txtSalePrice.BorderStyle = BorderStyle.FixedSingle;
            txtSalePrice.CharacterCasing = CharacterCasing.Lower;
            txtSalePrice.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalePrice.ForeColor = Color.FromArgb(0, 125, 250);
            txtSalePrice.Location = new Point(61, 306);
            txtSalePrice.MaxLength = 30;
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.PlaceholderText = "Obligatorio";
            txtSalePrice.Size = new Size(280, 29);
            txtSalePrice.TabIndex = 7;
            txtSalePrice.TextAlign = HorizontalAlignment.Center;
            txtSalePrice.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 120);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 3;
            label1.Text = "Categoría";
            // 
            // txtBarCode
            // 
            txtBarCode.AcceptsReturn = true;
            txtBarCode.AcceptsTab = true;
            txtBarCode.Anchor = AnchorStyles.None;
            txtBarCode.BackColor = Color.FromArgb(35, 35, 35);
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarCode.ForeColor = Color.FromArgb(0, 125, 250);
            txtBarCode.Location = new Point(441, 143);
            txtBarCode.MaxLength = 50;
            txtBarCode.Name = "txtBarCode";
            txtBarCode.PlaceholderText = "Opcional";
            txtBarCode.Size = new Size(280, 29);
            txtBarCode.TabIndex = 11;
            txtBarCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBarCode
            // 
            lblBarCode.Anchor = AnchorStyles.None;
            lblBarCode.AutoSize = true;
            lblBarCode.BackColor = Color.Transparent;
            lblBarCode.ForeColor = Color.White;
            lblBarCode.Location = new Point(441, 121);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(126, 19);
            lblBarCode.TabIndex = 10;
            lblBarCode.Text = "Código de barras";
            // 
            // cmbCategories
            // 
            cmbCategories.Anchor = AnchorStyles.None;
            cmbCategories.BackColor = Color.FromArgb(35, 35, 35);
            cmbCategories.FlatStyle = FlatStyle.Flat;
            cmbCategories.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategories.ForeColor = Color.FromArgb(0, 125, 250);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(61, 142);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(280, 29);
            cmbCategories.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.AcceptsTab = true;
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.BackColor = Color.FromArgb(35, 35, 35);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.FromArgb(0, 125, 250);
            txtDescription.Location = new Point(441, 219);
            txtDescription.MaxLength = 200;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Describa el artículo";
            txtDescription.Size = new Size(280, 116);
            txtDescription.TabIndex = 13;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(441, 197);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(87, 19);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Descripción";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.BackColor = Color.FromArgb(25, 25, 25);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 125, 250);
            btnSave.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            btnSave.IconColor = Color.FromArgb(0, 125, 250);
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 30;
            btnSave.Location = new Point(312, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 46);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // chkIsProducible
            // 
            chkIsProducible.Anchor = AnchorStyles.None;
            chkIsProducible.AutoSize = true;
            chkIsProducible.BackColor = Color.Transparent;
            chkIsProducible.ForeColor = Color.White;
            chkIsProducible.Location = new Point(61, 187);
            chkIsProducible.Name = "chkIsProducible";
            chkIsProducible.Size = new Size(243, 23);
            chkIsProducible.TabIndex = 15;
            chkIsProducible.Text = "¿Artículo de producción propia?";
            chkIsProducible.UseVisualStyleBackColor = false;
            chkIsProducible.CheckedChanged += ChkIsProducible_CheckedChanged;
            // 
            // btnAssociateSupplies
            // 
            btnAssociateSupplies.Anchor = AnchorStyles.None;
            btnAssociateSupplies.BackColor = Color.FromArgb(25, 25, 25);
            btnAssociateSupplies.FlatAppearance.BorderSize = 0;
            btnAssociateSupplies.FlatStyle = FlatStyle.Flat;
            btnAssociateSupplies.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssociateSupplies.ForeColor = Color.FromArgb(0, 125, 250);
            btnAssociateSupplies.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAssociateSupplies.IconColor = Color.FromArgb(0, 125, 250);
            btnAssociateSupplies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAssociateSupplies.IconSize = 30;
            btnAssociateSupplies.ImageAlign = ContentAlignment.MiddleLeft;
            btnAssociateSupplies.Location = new Point(120, 216);
            btnAssociateSupplies.Name = "btnAssociateSupplies";
            btnAssociateSupplies.Size = new Size(184, 30);
            btnAssociateSupplies.TabIndex = 16;
            btnAssociateSupplies.Text = "Asociar insumos";
            btnAssociateSupplies.TextAlign = ContentAlignment.MiddleRight;
            btnAssociateSupplies.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAssociateSupplies.UseVisualStyleBackColor = true;
            btnAssociateSupplies.Visible = false;
            btnAssociateSupplies.Click += BtnAssociateSuppies_Click;
            // 
            // dgvAssociatedSupplies
            // 
            dgvAssociatedSupplies.AllowUserToAddRows = false;
            dgvAssociatedSupplies.AllowUserToDeleteRows = false;
            dgvAssociatedSupplies.AllowUserToResizeRows = false;
            dgvAssociatedSupplies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAssociatedSupplies.BackgroundColor = Color.FromArgb(35, 35, 35);
            dgvAssociatedSupplies.BorderStyle = BorderStyle.Fixed3D;
            dgvAssociatedSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociatedSupplies.GridColor = SystemColors.InactiveCaptionText;
            dgvAssociatedSupplies.Location = new Point(441, 121);
            dgvAssociatedSupplies.Name = "dgvAssociatedSupplies";
            dgvAssociatedSupplies.ReadOnly = true;
            dgvAssociatedSupplies.RowHeadersVisible = false;
            dgvAssociatedSupplies.RowTemplate.Height = 25;
            dgvAssociatedSupplies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedSupplies.Size = new Size(280, 214);
            dgvAssociatedSupplies.TabIndex = 17;
            dgvAssociatedSupplies.Visible = false;
            // 
            // lblDgvAssociatedSupplies
            // 
            lblDgvAssociatedSupplies.Anchor = AnchorStyles.None;
            lblDgvAssociatedSupplies.AutoSize = true;
            lblDgvAssociatedSupplies.BackColor = Color.Transparent;
            lblDgvAssociatedSupplies.ForeColor = Color.White;
            lblDgvAssociatedSupplies.Location = new Point(441, 99);
            lblDgvAssociatedSupplies.Name = "lblDgvAssociatedSupplies";
            lblDgvAssociatedSupplies.Size = new Size(133, 19);
            lblDgvAssociatedSupplies.TabIndex = 18;
            lblDgvAssociatedSupplies.Text = "Insumos asociados";
            // 
            // cmbSupplies
            // 
            cmbSupplies.Anchor = AnchorStyles.None;
            cmbSupplies.BackColor = Color.FromArgb(35, 35, 35);
            cmbSupplies.FlatStyle = FlatStyle.Flat;
            cmbSupplies.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSupplies.ForeColor = Color.FromArgb(0, 125, 250);
            cmbSupplies.FormattingEnabled = true;
            cmbSupplies.Location = new Point(441, 58);
            cmbSupplies.Name = "cmbSupplies";
            cmbSupplies.Size = new Size(280, 29);
            cmbSupplies.TabIndex = 19;
            // 
            // lblSupplyList
            // 
            lblSupplyList.Anchor = AnchorStyles.None;
            lblSupplyList.AutoSize = true;
            lblSupplyList.BackColor = Color.Transparent;
            lblSupplyList.ForeColor = Color.White;
            lblSupplyList.Location = new Point(441, 36);
            lblSupplyList.Name = "lblSupplyList";
            lblSupplyList.Size = new Size(118, 19);
            lblSupplyList.TabIndex = 20;
            lblSupplyList.Text = "Lista de insumos";
            lblSupplyList.Click += lblSupplies_Click;
            // 
            // AddItemScreen
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(784, 470);
            Controls.Add(lblSupplyList);
            Controls.Add(cmbSupplies);
            Controls.Add(btnAssociateSupplies);
            Controls.Add(chkIsProducible);
            Controls.Add(btnSave);
            Controls.Add(cmbCategories);
            Controls.Add(lblBarCode);
            Controls.Add(label1);
            Controls.Add(txtBarCode);
            Controls.Add(lblSalePrice);
            Controls.Add(txtSalePrice);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(txtCodeName);
            Controls.Add(lblItemName);
            Controls.Add(txtItemName);
            Controls.Add(chkIsForSale);
            Controls.Add(dgvAssociatedSupplies);
            Controls.Add(lblDgvAssociatedSupplies);
            Controls.Add(lblCodeName);
            ForeColor = SystemColors.ActiveCaption;
            Name = "AddItemScreen";
            Padding = new Padding(60);
            Text = "Agregar nuevo item";
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedSupplies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsForSale;
        private Label lblItemName;
        private Label lblCodeName;
        private Label lblSalePrice;
        private CustomTextBox txtItemName;
        private CustomTextBox txtCodeName;
        private CustomTextBox txtSalePrice;
        private Label label1;
        private CustomTextBox txtBarCode;
        private Label lblBarCode;
        private ComboBox cmbCategories;
        private CustomTextBox txtDescription;
        private Label lblDescription;
        private CustomButton btnSave;
        private CheckBox chkIsProducible;
        private CustomButton btnAssociateSupplies;
        private CustomDataGridView dgvAssociatedSupplies;
        private Label lblDgvAssociatedSupplies;
        private ComboBox cmbSupplies;
        private Label lblSupplyList;
    }
}