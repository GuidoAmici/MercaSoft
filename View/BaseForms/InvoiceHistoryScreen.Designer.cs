namespace View
{
    partial class InvoiceHistoryScreen
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
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblInvoiceHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(63, 68);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowTemplate.Height = 25;
            this.dgvInvoices.Size = new System.Drawing.Size(674, 349);
            this.dgvInvoices.TabIndex = 1;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(Entities.Invoice);
            // 
            // lblInvoiceHistory
            // 
            this.lblInvoiceHistory.AutoSize = true;
            this.lblInvoiceHistory.Location = new System.Drawing.Point(63, 46);
            this.lblInvoiceHistory.Name = "lblInvoiceHistory";
            this.lblInvoiceHistory.Size = new System.Drawing.Size(144, 19);
            this.lblInvoiceHistory.TabIndex = 0;
            this.lblInvoiceHistory.Text = "Historial de facturas";
            // 
            // InvoiceHistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInvoiceHistory);
            this.Controls.Add(this.dgvInvoices);
            this.Name = "InvoiceHistoryScreen";
            this.Text = "BaseHistoryScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvInvoices;
        private BindingSource invoiceBindingSource;
        private Label lblInvoiceHistory;
    }
}