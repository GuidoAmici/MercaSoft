namespace View
{
    partial class ProductionOrderHistoryScreen
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
            dgvProductionOrders = new CustomDataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionOrderBindingSource = new BindingSource(components);
            btnSave = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)dgvProductionOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productionOrderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvProductionOrders
            // 
            dgvProductionOrders.AllowUserToAddRows = false;
            dgvProductionOrders.AllowUserToDeleteRows = false;
            dgvProductionOrders.AllowUserToResizeRows = false;
            dgvProductionOrders.AutoGenerateColumns = false;
            dgvProductionOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvProductionOrders.BackgroundColor = Color.FromArgb(35, 35, 35);
            dgvProductionOrders.BorderStyle = BorderStyle.Fixed3D;
            dgvProductionOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductionOrders.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, dateTimeDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn, itemDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dgvProductionOrders.DataSource = productionOrderBindingSource;
            dgvProductionOrders.GridColor = SystemColors.InactiveCaptionText;
            dgvProductionOrders.Location = new Point(63, 33);
            dgvProductionOrders.Name = "dgvProductionOrders";
            dgvProductionOrders.ReadOnly = true;
            dgvProductionOrders.RowHeadersVisible = false;
            dgvProductionOrders.RowTemplate.Height = 25;
            dgvProductionOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductionOrders.Size = new Size(674, 332);
            dgvProductionOrders.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 48;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            dateTimeDataGridViewTextBoxColumn.Width = 98;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.ReadOnly = true;
            userDataGridViewTextBoxColumn.Width = 64;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            itemDataGridViewTextBoxColumn.HeaderText = "Item";
            itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            itemDataGridViewTextBoxColumn.ReadOnly = true;
            itemDataGridViewTextBoxColumn.Width = 64;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 91;
            // 
            // productionOrderBindingSource
            // 
            productionOrderBindingSource.DataSource = typeof(Entities.ProductionOrder);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(25, 25, 25);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(0, 125, 250);
            btnSave.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            btnSave.IconColor = Color.FromArgb(0, 125, 250);
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 30;
            btnSave.Location = new Point(320, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 46);
            btnSave.TabIndex = 1;
            btnSave.Text = "Guardar";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // ProductionOrderHistoryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(dgvProductionOrders);
            Name = "ProductionOrderHistoryScreen";
            Text = "ProductionOrderHistory";
            ((System.ComponentModel.ISupportInitialize)dgvProductionOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)productionOrderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomDataGridView dgvProductionOrders;
        private BindingSource productionOrderBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private CustomButton btnSave;
    }
}