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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodeName = new System.Windows.Forms.Label();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkIsForSale
            // 
            this.chkIsForSale.AutoSize = true;
            this.chkIsForSale.BackColor = System.Drawing.Color.Transparent;
            this.chkIsForSale.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkIsForSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.chkIsForSale.Location = new System.Drawing.Point(390, 27);
            this.chkIsForSale.Name = "chkIsForSale";
            this.chkIsForSale.Size = new System.Drawing.Size(185, 23);
            this.chkIsForSale.TabIndex = 0;
            this.chkIsForSale.Text = "¿Artículo para la venta?";
            this.chkIsForSale.UseVisualStyleBackColor = false;
            this.chkIsForSale.CheckedChanged += new System.EventHandler(this.chkIsForSale_CheckedChanged);
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = true;
            this.txtUser.AcceptsTab = true;
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtUser.Location = new System.Drawing.Point(78, 49);
            this.txtUser.MaxLength = 30;
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Nombre del artículo";
            this.txtUser.Size = new System.Drawing.Size(240, 32);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del artículo";
            // 
            // lblCodeName
            // 
            this.lblCodeName.AutoSize = true;
            this.lblCodeName.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeName.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCodeName.Location = new System.Drawing.Point(78, 106);
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
            this.txtCodeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCodeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtCodeName.Location = new System.Drawing.Point(78, 128);
            this.txtCodeName.MaxLength = 30;
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.PlaceholderText = "Código del artículo";
            this.txtCodeName.Size = new System.Drawing.Size(240, 32);
            this.txtCodeName.TabIndex = 4;
            this.txtCodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePrice.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSalePrice.Location = new System.Drawing.Point(390, 56);
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
            this.txtSalePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalePrice.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.txtSalePrice.Location = new System.Drawing.Point(390, 78);
            this.txtSalePrice.MaxLength = 30;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PlaceholderText = "Precio de venta";
            this.txtSalePrice.Size = new System.Drawing.Size(240, 32);
            this.txtSalePrice.TabIndex = 6;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalePrice.Visible = false;
            // 
            // AddItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.lblCodeName);
            this.Controls.Add(this.txtCodeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.chkIsForSale);
            this.Name = "AddItemScreen";
            this.Text = "Agregar nuevo item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkIsForSale;
        private TextBox txtUser;
        private Label label1;
        private Label lblCodeName;
        private TextBox txtCodeName;
        private Label lblSalePrice;
        private TextBox txtSalePrice;
    }
}