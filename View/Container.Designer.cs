﻿namespace View
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuDashboard = new View.CustomMenuItem();
            this.menuSales = new View.CustomMenuItem();
            this.menuProduction = new View.CustomMenuItem();
            this.submenuAddProductionRow = new View.CustomSubmenuItem();
            this.submenuProductionOrders = new View.CustomSubmenuItem();
            this.submenuAddProductionOrder = new View.CustomSubmenuItem();
            this.submenuProductionOrderHistory = new View.CustomSubmenuItem();
            this.menuInventory = new View.CustomMenuItem();
            this.btnAddNewItem = new View.CustomSubmenuItem();
            this.submenuCheckInventory = new View.CustomSubmenuItem();
            this.submenuMoveHistory = new View.CustomSubmenuItem();
            this.customSubmenuItem4 = new View.CustomSubmenuItem();
            this.menuBuys = new View.CustomMenuItem();
            this.submenuAddBuyInvoice = new View.CustomSubmenuItem();
            this.submenuBuyHistory = new View.CustomSubmenuItem();
            this.menuLogistics = new View.CustomMenuItem();
            this.customSubmenuItem1 = new View.CustomSubmenuItem();
            this.menuMyUser = new View.CustomMenuItem();
            this.btnLogOut = new View.CustomSubmenuItem();
            this.iconMenuItem1 = new View.CustomSubmenuItem();
            this.submenuSellOrder = new View.CustomSubmenuItem();
            this.submenuAddSaleOrder = new View.CustomSubmenuItem();
            this.submenuInvoices = new View.CustomSubmenuItem();
            this.submenuAddSale = new View.CustomSubmenuItem();
            this.submenuSalesHistory = new View.CustomSubmenuItem();
            this.submenuSaleOrderHistory = new View.CustomSubmenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 100);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(1);
            this.mainPanel.Size = new System.Drawing.Size(784, 461);
            this.mainPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuStrip.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDashboard,
            this.menuSales,
            this.menuProduction,
            this.menuInventory,
            this.menuBuys,
            this.menuLogistics,
            this.menuMyUser});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip.Size = new System.Drawing.Size(784, 100);
            this.menuStrip.TabIndex = 2;
            // 
            // menuDashboard
            // 
            this.menuDashboard.AutoSize = false;
            this.menuDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuDashboard.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.menuDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDashboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDashboard.Name = "Menu";
            this.menuDashboard.Size = new System.Drawing.Size(94, 80);
            this.menuDashboard.Text = "Dashboard";
            this.menuDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuDashboard.Click += new System.EventHandler(this.menuDashboard_Click);
            // 
            // menuSales
            // 
            this.menuSales.AutoSize = false;
            this.menuSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuInvoices,
            this.submenuSellOrder});
            this.menuSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuSales.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuSales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSales.Name = "Menu";
            this.menuSales.Size = new System.Drawing.Size(94, 80);
            this.menuSales.Text = "Ventas";
            this.menuSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuProduction
            // 
            this.menuProduction.AutoSize = false;
            this.menuProduction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAddProductionRow,
            this.submenuProductionOrders});
            this.menuProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuProduction.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            this.menuProduction.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuProduction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProduction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProduction.Name = "Menu";
            this.menuProduction.Size = new System.Drawing.Size(94, 80);
            this.menuProduction.Text = "Producción";
            this.menuProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuAddProductionRow
            // 
            this.submenuAddProductionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddProductionRow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuAddProductionRow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddProductionRow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuAddProductionRow.IconSize = 20;
            this.submenuAddProductionRow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuAddProductionRow.Name = "submenu";
            this.submenuAddProductionRow.Size = new System.Drawing.Size(286, 26);
            this.submenuAddProductionRow.Text = "Registrar tanda de producción";
            this.submenuAddProductionRow.Click += new System.EventHandler(this.submenuAddProductionRow_Click);
            // 
            // submenuProductionOrders
            // 
            this.submenuProductionOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAddProductionOrder,
            this.submenuProductionOrderHistory});
            this.submenuProductionOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuProductionOrders.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuProductionOrders.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuProductionOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProductionOrders.IconSize = 20;
            this.submenuProductionOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuProductionOrders.Name = "submenu";
            this.submenuProductionOrders.Size = new System.Drawing.Size(286, 26);
            this.submenuProductionOrders.Text = "Ordenes de producción";
            // 
            // submenuAddProductionOrder
            // 
            this.submenuAddProductionOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddProductionOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuAddProductionOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddProductionOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuAddProductionOrder.IconSize = 20;
            this.submenuAddProductionOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuAddProductionOrder.Name = "submenu";
            this.submenuAddProductionOrder.Size = new System.Drawing.Size(209, 26);
            this.submenuAddProductionOrder.Text = "Emitir nueva orden";
            this.submenuAddProductionOrder.Click += new System.EventHandler(this.submenuAddProductionOrder_Click);
            // 
            // submenuProductionOrderHistory
            // 
            this.submenuProductionOrderHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuProductionOrderHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuProductionOrderHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuProductionOrderHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProductionOrderHistory.IconSize = 20;
            this.submenuProductionOrderHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuProductionOrderHistory.Name = "submenu";
            this.submenuProductionOrderHistory.Size = new System.Drawing.Size(209, 26);
            this.submenuProductionOrderHistory.Text = "Ver historial";
            this.submenuProductionOrderHistory.Click += new System.EventHandler(this.submenuProductionOrderHistory_Click);
            // 
            // menuInventory
            // 
            this.menuInventory.AutoSize = false;
            this.menuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewItem,
            this.submenuCheckInventory,
            this.submenuMoveHistory,
            this.customSubmenuItem4});
            this.menuInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.menuInventory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInventory.Name = "Menu";
            this.menuInventory.Size = new System.Drawing.Size(94, 80);
            this.menuInventory.Text = "Inventario";
            this.menuInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnAddNewItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddNewItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnAddNewItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewItem.IconSize = 20;
            this.btnAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNewItem.Name = "submenu";
            this.btnAddNewItem.Size = new System.Drawing.Size(251, 26);
            this.btnAddNewItem.Text = "Agregar nuevo artículo";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // submenuCheckInventory
            // 
            this.submenuCheckInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuCheckInventory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuCheckInventory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuCheckInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuCheckInventory.IconSize = 20;
            this.submenuCheckInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuCheckInventory.Name = "submenu";
            this.submenuCheckInventory.Size = new System.Drawing.Size(251, 26);
            this.submenuCheckInventory.Text = "Ver inventario";
            this.submenuCheckInventory.Click += new System.EventHandler(this.submenuCheckInventory_Click);
            // 
            // submenuMoveHistory
            // 
            this.submenuMoveHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuMoveHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuMoveHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuMoveHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuMoveHistory.IconSize = 20;
            this.submenuMoveHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuMoveHistory.Name = "submenu";
            this.submenuMoveHistory.Size = new System.Drawing.Size(251, 26);
            this.submenuMoveHistory.Text = "Historial de movimientos";
            // 
            // customSubmenuItem4
            // 
            this.customSubmenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.customSubmenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.customSubmenuItem4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.customSubmenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customSubmenuItem4.IconSize = 20;
            this.customSubmenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customSubmenuItem4.Name = "submenu";
            this.customSubmenuItem4.Size = new System.Drawing.Size(251, 26);
            this.customSubmenuItem4.Text = "Devoluciones";
            // 
            // menuBuys
            // 
            this.menuBuys.AutoSize = false;
            this.menuBuys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAddBuyInvoice,
            this.submenuBuyHistory});
            this.menuBuys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuBuys.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.menuBuys.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuBuys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuBuys.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBuys.Name = "Menu";
            this.menuBuys.Size = new System.Drawing.Size(94, 80);
            this.menuBuys.Text = "Compras";
            this.menuBuys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuAddBuyInvoice
            // 
            this.submenuAddBuyInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddBuyInvoice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuAddBuyInvoice.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddBuyInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuAddBuyInvoice.IconSize = 20;
            this.submenuAddBuyInvoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuAddBuyInvoice.Name = "submenu";
            this.submenuAddBuyInvoice.Size = new System.Drawing.Size(233, 26);
            this.submenuAddBuyInvoice.Text = "Agregar nueva factura";
            // 
            // submenuBuyHistory
            // 
            this.submenuBuyHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuBuyHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuBuyHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuBuyHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuBuyHistory.IconSize = 20;
            this.submenuBuyHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuBuyHistory.Name = "submenu";
            this.submenuBuyHistory.Size = new System.Drawing.Size(233, 26);
            this.submenuBuyHistory.Text = "Historial de compras";
            // 
            // menuLogistics
            // 
            this.menuLogistics.AutoSize = false;
            this.menuLogistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customSubmenuItem1});
            this.menuLogistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuLogistics.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menuLogistics.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuLogistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuLogistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuLogistics.Name = "Menu";
            this.menuLogistics.Size = new System.Drawing.Size(94, 80);
            this.menuLogistics.Text = "Logística";
            this.menuLogistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // customSubmenuItem1
            // 
            this.customSubmenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.customSubmenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.customSubmenuItem1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.customSubmenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customSubmenuItem1.IconSize = 20;
            this.customSubmenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customSubmenuItem1.Name = "submenu";
            this.customSubmenuItem1.Size = new System.Drawing.Size(184, 26);
            this.customSubmenuItem1.Text = "Emitir remito";
            // 
            // menuMyUser
            // 
            this.menuMyUser.AutoSize = false;
            this.menuMyUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOut});
            this.menuMyUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuMyUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuMyUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.menuMyUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMyUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMyUser.Name = "Menu";
            this.menuMyUser.Size = new System.Drawing.Size(94, 80);
            this.menuMyUser.Text = "Mi Usuario";
            this.menuMyUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 20;
            this.btnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogOut.Name = "submenu";
            this.btnLogOut.Size = new System.Drawing.Size(184, 26);
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 20;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "submenu";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // submenuSellOrder
            // 
            this.submenuSellOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAddSaleOrder,
            this.submenuSaleOrderHistory});
            this.submenuSellOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuSellOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuSellOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuSellOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuSellOrder.IconSize = 20;
            this.submenuSellOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuSellOrder.Name = "submenu";
            this.submenuSellOrder.Size = new System.Drawing.Size(158, 26);
            this.submenuSellOrder.Text = "Pedidos";
            // 
            // submenuAddSaleOrder
            // 
            this.submenuAddSaleOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddSaleOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuAddSaleOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddSaleOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuAddSaleOrder.IconSize = 20;
            this.submenuAddSaleOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuAddSaleOrder.Name = "submenu";
            this.submenuAddSaleOrder.Size = new System.Drawing.Size(218, 26);
            this.submenuAddSaleOrder.Text = "Nuevo pedido";
            // 
            // submenuInvoices
            // 
            this.submenuInvoices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAddSale,
            this.submenuSalesHistory});
            this.submenuInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuInvoices.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuInvoices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuInvoices.IconSize = 20;
            this.submenuInvoices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuInvoices.Name = "submenu";
            this.submenuInvoices.Size = new System.Drawing.Size(158, 26);
            this.submenuInvoices.Text = "Facturación";
            // 
            // submenuAddSale
            // 
            this.submenuAddSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddSale.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuAddSale.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuAddSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuAddSale.IconSize = 20;
            this.submenuAddSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuAddSale.Name = "submenu";
            this.submenuAddSale.Size = new System.Drawing.Size(207, 26);
            this.submenuAddSale.Text = "Emitir factura";
            // 
            // submenuSalesHistory
            // 
            this.submenuSalesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuSalesHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuSalesHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuSalesHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuSalesHistory.IconSize = 20;
            this.submenuSalesHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuSalesHistory.Name = "submenu";
            this.submenuSalesHistory.Size = new System.Drawing.Size(207, 26);
            this.submenuSalesHistory.Text = "Historial de ventas";
            // 
            // submenuSaleOrderHistory
            // 
            this.submenuSaleOrderHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuSaleOrderHistory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuSaleOrderHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.submenuSaleOrderHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuSaleOrderHistory.IconSize = 20;
            this.submenuSaleOrderHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuSaleOrderHistory.Name = "submenu";
            this.submenuSaleOrderHistory.Size = new System.Drawing.Size(218, 26);
            this.submenuSaleOrderHistory.Text = "Historial de pedidos";
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercaSoft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Container_FormClosing);
            this.Load += new System.EventHandler(this.Container_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CustomSubmenuItem iconMenuItem1;
        private CustomSubmenuItem submenuAddProductionRow;
        private CustomSubmenuItem submenuProductionOrders;
        private CustomSubmenuItem submenuCheckInventory;
        private CustomSubmenuItem submenuMoveHistory;
        private CustomSubmenuItem submenuAddBuyInvoice;
        private CustomSubmenuItem submenuBuyHistory;
        private CustomMenuItem menuLogistics;
        private CustomSubmenuItem customSubmenuItem1;
        private CustomSubmenuItem submenuAddProductionOrder;
        private CustomSubmenuItem submenuProductionOrderHistory;
        private CustomSubmenuItem customSubmenuItem4;
        private CustomSubmenuItem submenuInvoices;
        private CustomSubmenuItem submenuAddSale;
        private CustomSubmenuItem submenuSalesHistory;
        private CustomSubmenuItem submenuSellOrder;
        private CustomSubmenuItem submenuAddSaleOrder;
        private CustomSubmenuItem submenuSaleOrderHistory;
    }
}