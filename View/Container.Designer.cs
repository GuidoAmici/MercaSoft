namespace View
{
    partial class Container
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            menuStrip = new MenuStrip();
            menuDashboard = new CustomMenuItem();
            menuSales = new CustomMenuItem();
            submenuInvoices = new CustomSubmenuItem();
            submenuAddSale = new CustomSubmenuItem();
            submenuSalesHistory = new CustomSubmenuItem();
            submenuSellOrder = new CustomSubmenuItem();
            submenuAddSaleOrder = new CustomSubmenuItem();
            submenuSaleOrderHistory = new CustomSubmenuItem();
            menuProduction = new CustomMenuItem();
            submenuAddProductionRow = new CustomSubmenuItem();
            submenuProductionOrders = new CustomSubmenuItem();
            submenuAddProductionOrder = new CustomSubmenuItem();
            submenuProductionOrderHistory = new CustomSubmenuItem();
            menuInventory = new CustomMenuItem();
            btnAddNewItem = new CustomSubmenuItem();
            submenuCheckInventory = new CustomSubmenuItem();
            submenuMoveHistory = new CustomSubmenuItem();
            submenuReturns = new CustomSubmenuItem();
            menuBuys = new CustomMenuItem();
            submenuAddBuyInvoice = new CustomSubmenuItem();
            submenuBuyHistory = new CustomSubmenuItem();
            menuLogistics = new CustomMenuItem();
            submenuAddDeliveryNote = new CustomSubmenuItem();
            menuMyUser = new CustomMenuItem();
            btnLogOut = new CustomSubmenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(35, 35, 35);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            mainPanel.ForeColor = Color.FromArgb(0, 126, 249);
            mainPanel.Location = new Point(0, 100);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(1);
            mainPanel.Size = new Size(784, 461);
            mainPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(25, 25, 25);
            menuStrip.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip.GripMargin = new Padding(2);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuDashboard, menuSales, menuProduction, menuInventory, menuBuys, menuLogistics, menuMyUser });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10);
            menuStrip.Size = new Size(784, 100);
            menuStrip.TabIndex = 2;
            // 
            // menuDashboard
            // 
            menuDashboard.AutoSize = false;
            menuDashboard.ForeColor = Color.FromArgb(0, 125, 250);
            menuDashboard.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            menuDashboard.IconColor = Color.FromArgb(0, 125, 250);
            menuDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuDashboard.ImageScaling = ToolStripItemImageScaling.None;
            menuDashboard.Name = "Menu";
            menuDashboard.Size = new Size(94, 80);
            menuDashboard.Text = "Dashboard";
            menuDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            menuDashboard.Click += MenuDashboard_Click;
            // 
            // menuSales
            // 
            menuSales.AutoSize = false;
            menuSales.DropDownItems.AddRange(new ToolStripItem[] { submenuInvoices, submenuSellOrder });
            menuSales.ForeColor = Color.FromArgb(0, 125, 250);
            menuSales.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuSales.IconColor = Color.FromArgb(0, 125, 250);
            menuSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuSales.ImageScaling = ToolStripItemImageScaling.None;
            menuSales.Name = "Menu";
            menuSales.Size = new Size(94, 80);
            menuSales.Text = "Ventas";
            menuSales.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuInvoices
            // 
            submenuInvoices.DropDownItems.AddRange(new ToolStripItem[] { submenuAddSale, submenuSalesHistory });
            submenuInvoices.ForeColor = Color.FromArgb(0, 125, 250);
            submenuInvoices.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuInvoices.IconColor = Color.FromArgb(0, 125, 250);
            submenuInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuInvoices.IconSize = 20;
            submenuInvoices.ImageScaling = ToolStripItemImageScaling.None;
            submenuInvoices.Name = "submenu";
            submenuInvoices.Size = new Size(158, 26);
            submenuInvoices.Text = "Facturación";
            // 
            // submenuAddSale
            // 
            submenuAddSale.ForeColor = Color.FromArgb(0, 125, 250);
            submenuAddSale.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuAddSale.IconColor = Color.FromArgb(0, 125, 250);
            submenuAddSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuAddSale.IconSize = 20;
            submenuAddSale.ImageScaling = ToolStripItemImageScaling.None;
            submenuAddSale.Name = "submenu";
            submenuAddSale.Size = new Size(207, 26);
            submenuAddSale.Text = "Emitir factura";
            // 
            // submenuSalesHistory
            // 
            submenuSalesHistory.ForeColor = Color.FromArgb(0, 125, 250);
            submenuSalesHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuSalesHistory.IconColor = Color.FromArgb(0, 125, 250);
            submenuSalesHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuSalesHistory.IconSize = 20;
            submenuSalesHistory.ImageScaling = ToolStripItemImageScaling.None;
            submenuSalesHistory.Name = "submenu";
            submenuSalesHistory.Size = new Size(207, 26);
            submenuSalesHistory.Text = "Historial de ventas";
            // 
            // submenuSellOrder
            // 
            submenuSellOrder.DropDownItems.AddRange(new ToolStripItem[] { submenuAddSaleOrder, submenuSaleOrderHistory });
            submenuSellOrder.ForeColor = Color.FromArgb(0, 125, 250);
            submenuSellOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuSellOrder.IconColor = Color.FromArgb(0, 125, 250);
            submenuSellOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuSellOrder.IconSize = 20;
            submenuSellOrder.ImageScaling = ToolStripItemImageScaling.None;
            submenuSellOrder.Name = "submenu";
            submenuSellOrder.Size = new Size(158, 26);
            submenuSellOrder.Text = "Pedidos";
            // 
            // submenuAddSaleOrder
            // 
            submenuAddSaleOrder.ForeColor = Color.FromArgb(0, 125, 250);
            submenuAddSaleOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuAddSaleOrder.IconColor = Color.FromArgb(0, 125, 250);
            submenuAddSaleOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuAddSaleOrder.IconSize = 20;
            submenuAddSaleOrder.ImageScaling = ToolStripItemImageScaling.None;
            submenuAddSaleOrder.Name = "submenu";
            submenuAddSaleOrder.Size = new Size(218, 26);
            submenuAddSaleOrder.Text = "Nuevo pedido";
            // 
            // submenuSaleOrderHistory
            // 
            submenuSaleOrderHistory.ForeColor = Color.FromArgb(0, 125, 250);
            submenuSaleOrderHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuSaleOrderHistory.IconColor = Color.FromArgb(0, 125, 250);
            submenuSaleOrderHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuSaleOrderHistory.IconSize = 20;
            submenuSaleOrderHistory.ImageScaling = ToolStripItemImageScaling.None;
            submenuSaleOrderHistory.Name = "submenu";
            submenuSaleOrderHistory.Size = new Size(218, 26);
            submenuSaleOrderHistory.Text = "Historial de pedidos";
            // 
            // menuProduction
            // 
            menuProduction.AutoSize = false;
            menuProduction.DropDownItems.AddRange(new ToolStripItem[] { submenuAddProductionRow, submenuProductionOrders });
            menuProduction.ForeColor = Color.FromArgb(0, 125, 250);
            menuProduction.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            menuProduction.IconColor = Color.FromArgb(0, 125, 250);
            menuProduction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProduction.ImageScaling = ToolStripItemImageScaling.None;
            menuProduction.Name = "Menu";
            menuProduction.Size = new Size(94, 80);
            menuProduction.Text = "Producción";
            menuProduction.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuAddProductionRow
            // 
            submenuAddProductionRow.ForeColor = Color.FromArgb(0, 125, 250);
            submenuAddProductionRow.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuAddProductionRow.IconColor = Color.FromArgb(0, 125, 250);
            submenuAddProductionRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuAddProductionRow.IconSize = 20;
            submenuAddProductionRow.ImageScaling = ToolStripItemImageScaling.None;
            submenuAddProductionRow.Name = "submenu";
            submenuAddProductionRow.Size = new Size(286, 26);
            submenuAddProductionRow.Text = "Registrar tanda de producción";
            submenuAddProductionRow.Click += SubmenuAddProductionRow_Click;
            // 
            // submenuProductionOrders
            // 
            submenuProductionOrders.DropDownItems.AddRange(new ToolStripItem[] { submenuAddProductionOrder, submenuProductionOrderHistory });
            submenuProductionOrders.ForeColor = Color.FromArgb(0, 125, 250);
            submenuProductionOrders.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuProductionOrders.IconColor = Color.FromArgb(0, 125, 250);
            submenuProductionOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuProductionOrders.IconSize = 20;
            submenuProductionOrders.ImageScaling = ToolStripItemImageScaling.None;
            submenuProductionOrders.Name = "submenu";
            submenuProductionOrders.Size = new Size(286, 26);
            submenuProductionOrders.Text = "Ordenes de producción";
            // 
            // submenuAddProductionOrder
            // 
            submenuAddProductionOrder.ForeColor = Color.FromArgb(0, 125, 250);
            submenuAddProductionOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuAddProductionOrder.IconColor = Color.FromArgb(0, 125, 250);
            submenuAddProductionOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuAddProductionOrder.IconSize = 20;
            submenuAddProductionOrder.ImageScaling = ToolStripItemImageScaling.None;
            submenuAddProductionOrder.Name = "submenu";
            submenuAddProductionOrder.Size = new Size(209, 26);
            submenuAddProductionOrder.Text = "Emitir nueva orden";
            submenuAddProductionOrder.Click += SubmenuAddProductionOrder_Click;
            // 
            // submenuProductionOrderHistory
            // 
            submenuProductionOrderHistory.ForeColor = Color.FromArgb(0, 125, 250);
            submenuProductionOrderHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuProductionOrderHistory.IconColor = Color.FromArgb(0, 125, 250);
            submenuProductionOrderHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuProductionOrderHistory.IconSize = 20;
            submenuProductionOrderHistory.ImageScaling = ToolStripItemImageScaling.None;
            submenuProductionOrderHistory.Name = "submenu";
            submenuProductionOrderHistory.Size = new Size(209, 26);
            submenuProductionOrderHistory.Text = "Ver historial";
            submenuProductionOrderHistory.Click += SubmenuProductionOrderHistory_Click;
            // 
            // menuInventory
            // 
            menuInventory.AutoSize = false;
            menuInventory.DropDownItems.AddRange(new ToolStripItem[] { btnAddNewItem, submenuCheckInventory, submenuMoveHistory, submenuReturns });
            menuInventory.ForeColor = Color.FromArgb(0, 125, 250);
            menuInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            menuInventory.IconColor = Color.FromArgb(0, 125, 250);
            menuInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuInventory.ImageScaling = ToolStripItemImageScaling.None;
            menuInventory.Name = "Menu";
            menuInventory.Size = new Size(94, 80);
            menuInventory.Text = "Inventario";
            menuInventory.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.ForeColor = Color.FromArgb(0, 125, 250);
            btnAddNewItem.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddNewItem.IconColor = Color.FromArgb(0, 125, 250);
            btnAddNewItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNewItem.IconSize = 20;
            btnAddNewItem.ImageScaling = ToolStripItemImageScaling.None;
            btnAddNewItem.Name = "submenu";
            btnAddNewItem.Size = new Size(251, 26);
            btnAddNewItem.Text = "Agregar nuevo artículo";
            btnAddNewItem.Click += BtnAddNewItem_Click;
            // 
            // submenuCheckInventory
            // 
            submenuCheckInventory.ForeColor = Color.FromArgb(0, 125, 250);
            submenuCheckInventory.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuCheckInventory.IconColor = Color.FromArgb(0, 125, 250);
            submenuCheckInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuCheckInventory.IconSize = 20;
            submenuCheckInventory.ImageScaling = ToolStripItemImageScaling.None;
            submenuCheckInventory.Name = "submenu";
            submenuCheckInventory.Size = new Size(251, 26);
            submenuCheckInventory.Text = "Ver inventario";
            submenuCheckInventory.Click += SubmenuCheckInventory_Click;
            // 
            // submenuMoveHistory
            // 
            submenuMoveHistory.ForeColor = Color.FromArgb(0, 125, 250);
            submenuMoveHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuMoveHistory.IconColor = Color.FromArgb(0, 125, 250);
            submenuMoveHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuMoveHistory.IconSize = 20;
            submenuMoveHistory.ImageScaling = ToolStripItemImageScaling.None;
            submenuMoveHistory.Name = "submenu";
            submenuMoveHistory.Size = new Size(251, 26);
            submenuMoveHistory.Text = "Historial de movimientos";
            // 
            // submenuReturns
            // 
            submenuReturns.ForeColor = Color.FromArgb(0, 125, 250);
            submenuReturns.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuReturns.IconColor = Color.FromArgb(0, 125, 250);
            submenuReturns.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuReturns.IconSize = 20;
            submenuReturns.ImageScaling = ToolStripItemImageScaling.None;
            submenuReturns.Name = "submenu";
            submenuReturns.Size = new Size(251, 26);
            submenuReturns.Text = "Devoluciones";
            // 
            // menuBuys
            // 
            menuBuys.AutoSize = false;
            menuBuys.DropDownItems.AddRange(new ToolStripItem[] { submenuAddBuyInvoice, submenuBuyHistory });
            menuBuys.ForeColor = Color.FromArgb(0, 125, 250);
            menuBuys.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            menuBuys.IconColor = Color.FromArgb(0, 125, 250);
            menuBuys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuBuys.ImageScaling = ToolStripItemImageScaling.None;
            menuBuys.Name = "Menu";
            menuBuys.Size = new Size(94, 80);
            menuBuys.Text = "Compras";
            menuBuys.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuAddBuyInvoice
            // 
            submenuAddBuyInvoice.ForeColor = Color.FromArgb(0, 125, 250);
            submenuAddBuyInvoice.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuAddBuyInvoice.IconColor = Color.FromArgb(0, 125, 250);
            submenuAddBuyInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuAddBuyInvoice.IconSize = 20;
            submenuAddBuyInvoice.ImageScaling = ToolStripItemImageScaling.None;
            submenuAddBuyInvoice.Name = "submenu";
            submenuAddBuyInvoice.Size = new Size(233, 26);
            submenuAddBuyInvoice.Text = "Agregar nueva factura";
            // 
            // submenuBuyHistory
            // 
            submenuBuyHistory.ForeColor = Color.FromArgb(0, 125, 250);
            submenuBuyHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuBuyHistory.IconColor = Color.FromArgb(0, 125, 250);
            submenuBuyHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuBuyHistory.IconSize = 20;
            submenuBuyHistory.ImageScaling = ToolStripItemImageScaling.None;
            submenuBuyHistory.Name = "submenu";
            submenuBuyHistory.Size = new Size(233, 26);
            submenuBuyHistory.Text = "Historial de compras";
            // 
            // menuLogistics
            // 
            menuLogistics.AutoSize = false;
            menuLogistics.DropDownItems.AddRange(new ToolStripItem[] { submenuAddDeliveryNote });
            menuLogistics.ForeColor = Color.FromArgb(0, 125, 250);
            menuLogistics.IconChar = FontAwesome.Sharp.IconChar.Truck;
            menuLogistics.IconColor = Color.FromArgb(0, 125, 250);
            menuLogistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuLogistics.ImageScaling = ToolStripItemImageScaling.None;
            menuLogistics.Name = "Menu";
            menuLogistics.Size = new Size(94, 80);
            menuLogistics.Text = "Logística";
            menuLogistics.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuAddDeliveryNote
            // 
            submenuAddDeliveryNote.ForeColor = Color.FromArgb(0, 125, 250);
            submenuAddDeliveryNote.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuAddDeliveryNote.IconColor = Color.FromArgb(0, 125, 250);
            submenuAddDeliveryNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuAddDeliveryNote.IconSize = 20;
            submenuAddDeliveryNote.ImageScaling = ToolStripItemImageScaling.None;
            submenuAddDeliveryNote.Name = "submenu";
            submenuAddDeliveryNote.Size = new Size(170, 26);
            submenuAddDeliveryNote.Text = "Emitir remito";
            // 
            // menuMyUser
            // 
            menuMyUser.AutoSize = false;
            menuMyUser.DropDownItems.AddRange(new ToolStripItem[] { btnLogOut });
            menuMyUser.ForeColor = Color.FromArgb(0, 125, 250);
            menuMyUser.IconChar = FontAwesome.Sharp.IconChar.User;
            menuMyUser.IconColor = Color.FromArgb(0, 125, 250);
            menuMyUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMyUser.ImageScaling = ToolStripItemImageScaling.None;
            menuMyUser.Name = "Menu";
            menuMyUser.Size = new Size(94, 80);
            menuMyUser.Text = "Mi Usuario";
            menuMyUser.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnLogOut
            // 
            btnLogOut.ForeColor = Color.FromArgb(0, 125, 250);
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogOut.IconColor = Color.FromArgb(0, 125, 250);
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.IconSize = 20;
            btnLogOut.ImageScaling = ToolStripItemImageScaling.None;
            btnLogOut.Name = "submenu";
            btnLogOut.Size = new Size(170, 26);
            btnLogOut.Text = "Cerrar sesión";
            btnLogOut.Click += BtnLogOut_Click;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(784, 561);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(800, 600);
            Name = "Container";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MercaSoft";
            FormClosing += Container_FormClosing;
            Load += Container_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel mainPanel;
        private MenuStrip menuStrip;
        private CustomMenuItem menuDashboard;
        private CustomMenuItem menuSales;
        private CustomMenuItem menuProduction;
        private CustomMenuItem menuInventory;
        private CustomMenuItem menuMyUser;
        private CustomMenuItem menuBuys;
        private CustomSubmenuItem btnLogOut;
        private CustomSubmenuItem btnAddNewItem;
        private CustomSubmenuItem submenuAddProductionRow;
        private CustomSubmenuItem submenuProductionOrders;
        private CustomSubmenuItem submenuCheckInventory;
        private CustomSubmenuItem submenuMoveHistory;
        private CustomSubmenuItem submenuAddBuyInvoice;
        private CustomSubmenuItem submenuBuyHistory;
        private CustomMenuItem menuLogistics;
        private CustomSubmenuItem submenuAddDeliveryNote;
        private CustomSubmenuItem submenuAddProductionOrder;
        private CustomSubmenuItem submenuProductionOrderHistory;
        private CustomSubmenuItem submenuReturns;
        private CustomSubmenuItem submenuInvoices;
        private CustomSubmenuItem submenuAddSale;
        private CustomSubmenuItem submenuSalesHistory;
        private CustomSubmenuItem submenuSellOrder;
        private CustomSubmenuItem submenuAddSaleOrder;
        private CustomSubmenuItem submenuSaleOrderHistory;
    }
}