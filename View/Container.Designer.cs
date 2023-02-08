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
            this.formsPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.submenuDashboard = new FontAwesome.Sharp.IconMenuItem();
            this.submenuSales = new FontAwesome.Sharp.IconMenuItem();
            this.submenuProduction = new FontAwesome.Sharp.IconMenuItem();
            this.submenuInventory = new FontAwesome.Sharp.IconMenuItem();
            this.btnAddNewItem = new FontAwesome.Sharp.IconMenuItem();
            this.submenuBuys = new FontAwesome.Sharp.IconMenuItem();
            this.submenuMyUser = new FontAwesome.Sharp.IconMenuItem();
            this.btnLogOut = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPanel
            // 
            this.formsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPanel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.formsPanel.Location = new System.Drawing.Point(0, 91);
            this.formsPanel.Name = "formsPanel";
            this.formsPanel.Size = new System.Drawing.Size(784, 470);
            this.formsPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.menuStrip.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuDashboard,
            this.submenuSales,
            this.submenuProduction,
            this.submenuInventory,
            this.submenuBuys,
            this.submenuMyUser});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip.Size = new System.Drawing.Size(784, 91);
            this.menuStrip.TabIndex = 2;
            // 
            // submenuDashboard
            // 
            this.submenuDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuDashboard.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.submenuDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuDashboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuDashboard.Name = "submenuDashboard";
            this.submenuDashboard.Size = new System.Drawing.Size(94, 71);
            this.submenuDashboard.Text = "Dashboard";
            this.submenuDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuSales
            // 
            this.submenuSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuSales.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.submenuSales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuSales.Name = "submenuSales";
            this.submenuSales.Size = new System.Drawing.Size(64, 71);
            this.submenuSales.Text = "Ventas";
            this.submenuSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuProduction
            // 
            this.submenuProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuProduction.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            this.submenuProduction.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuProduction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProduction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuProduction.Name = "submenuProduction";
            this.submenuProduction.Size = new System.Drawing.Size(97, 71);
            this.submenuProduction.Text = "Producción";
            this.submenuProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuInventory
            // 
            this.submenuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewItem});
            this.submenuInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.submenuInventory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuInventory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuInventory.Name = "submenuInventory";
            this.submenuInventory.Size = new System.Drawing.Size(89, 71);
            this.submenuInventory.Text = "Inventario";
            this.submenuInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddNewItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddNewItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddNewItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewItem.IconSize = 20;
            this.btnAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(238, 26);
            this.btnAddNewItem.Text = "Agregar nuevo articulo";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // submenuBuys
            // 
            this.submenuBuys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuBuys.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.submenuBuys.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuBuys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuBuys.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuBuys.Name = "submenuBuys";
            this.submenuBuys.Size = new System.Drawing.Size(81, 71);
            this.submenuBuys.Text = "Compras";
            this.submenuBuys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuMyUser
            // 
            this.submenuMyUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOut});
            this.submenuMyUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuMyUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.submenuMyUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.submenuMyUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuMyUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submenuMyUser.Name = "submenuMyUser";
            this.submenuMyUser.Size = new System.Drawing.Size(93, 71);
            this.submenuMyUser.Text = "Mi Usuario";
            this.submenuMyUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 20;
            this.btnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 26);
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.formsPanel);
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
        private Panel formsPanel;
        private MenuStrip menuStrip;
        private FontAwesome.Sharp.IconMenuItem submenuSales;
        private FontAwesome.Sharp.IconMenuItem submenuProduction;
        private FontAwesome.Sharp.IconMenuItem submenuInventory;
        private FontAwesome.Sharp.IconMenuItem submenuMyUser;
        private FontAwesome.Sharp.IconMenuItem submenuDashboard;
        private FontAwesome.Sharp.IconMenuItem submenuBuys;
        private FontAwesome.Sharp.IconMenuItem btnLogOut;
        private FontAwesome.Sharp.IconMenuItem btnAddNewItem;
    }
}