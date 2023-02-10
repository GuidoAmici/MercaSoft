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
            this.chkIsForSale = new System.Windows.Forms.CheckBox();
            this.txtItemName = new View.CustomTextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCodeName = new System.Windows.Forms.Label();
            this.txtCodeName = new View.CustomTextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new View.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new View.CustomTextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.txtDescription = new View.CustomTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new View.CustomButton();
            this.SuspendLayout();
            // 
            // chkIsForSale
            // 
            this.chkIsForSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkIsForSale.AutoSize = true;
            this.chkIsForSale.BackColor = System.Drawing.Color.Transparent;
            this.chkIsForSale.Location = new System.Drawing.Point(70, 243);
            this.chkIsForSale.Name = "chkIsForSale";
            this.chkIsForSale.Size = new System.Drawing.Size(185, 23);
            this.chkIsForSale.TabIndex = 0;
            this.chkIsForSale.Text = "¿Artículo para la venta?";
            this.chkIsForSale.UseVisualStyleBackColor = false;
            this.chkIsForSale.CheckedChanged += new System.EventHandler(this.chkIsForSale_CheckedChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.AcceptsReturn = true;
            this.txtItemName.AcceptsTab = true;
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtItemName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtItemName.Location = new System.Drawing.Point(72, 54);
            this.txtItemName.MaxLength = 50;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PlaceholderText = "Obligatorio";
            this.txtItemName.Size = new System.Drawing.Size(280, 39);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Location = new System.Drawing.Point(72, 32);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(145, 19);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Nombre del artículo";
            // 
            // lblCodeName
            // 
            this.lblCodeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodeName.AutoSize = true;
            this.lblCodeName.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeName.Location = new System.Drawing.Point(444, 32);
            this.lblCodeName.Name = "lblCodeName";
            this.lblCodeName.Size = new System.Drawing.Size(138, 19);
            this.lblCodeName.TabIndex = 5;
            this.lblCodeName.Text = "Código del artículo";
            // 
            // txtCodeName
            // 
            this.txtCodeName.AcceptsReturn = true;
            this.txtCodeName.AcceptsTab = true;
            this.txtCodeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtCodeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCodeName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtCodeName.Location = new System.Drawing.Point(444, 54);
            this.txtCodeName.MaxLength = 50;
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.PlaceholderText = "Opcional";
            this.txtCodeName.Size = new System.Drawing.Size(280, 39);
            this.txtCodeName.TabIndex = 4;
            this.txtCodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePrice.Location = new System.Drawing.Point(70, 275);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(114, 19);
            this.lblSalePrice.TabIndex = 7;
            this.lblSalePrice.Text = "Precio de venta";
            this.lblSalePrice.Visible = false;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.AcceptsReturn = true;
            this.txtSalePrice.AcceptsTab = true;
            this.txtSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSalePrice.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtSalePrice.Location = new System.Drawing.Point(70, 297);
            this.txtSalePrice.MaxLength = 30;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PlaceholderText = "Obligatorio";
            this.txtSalePrice.Size = new System.Drawing.Size(280, 39);
            this.txtSalePrice.TabIndex = 6;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalePrice.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(70, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoría";
            // 
            // txtBarCode
            // 
            this.txtBarCode.AcceptsReturn = true;
            this.txtBarCode.AcceptsTab = true;
            this.txtBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBarCode.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtBarCode.Location = new System.Drawing.Point(444, 146);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PlaceholderText = "Opcional";
            this.txtBarCode.Size = new System.Drawing.Size(280, 39);
            this.txtBarCode.TabIndex = 8;
            this.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBarCode
            // 
            this.lblBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.BackColor = System.Drawing.Color.Transparent;
            this.lblBarCode.Location = new System.Drawing.Point(444, 124);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(126, 19);
            this.lblBarCode.TabIndex = 9;
            this.lblBarCode.Text = "Código de barras";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(71, 145);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(279, 40);
            this.cmbCategories.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDescription.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.txtDescription.Location = new System.Drawing.Point(444, 240);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Describa el artículo";
            this.txtDescription.Size = new System.Drawing.Size(280, 139);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(444, 218);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 19);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Descripción";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(312, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 46);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddItemScreen
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCodeName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCodeName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.chkIsForSale);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "AddItemScreen";
            this.Text = "Agregar nuevo item";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}