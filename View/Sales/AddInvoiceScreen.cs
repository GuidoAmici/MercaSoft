﻿using Control;
using Entities;

namespace View
{
    public partial class AddInvoiceScreen : BaseForm
    {
        private Invoice Invoice;
        private Item SelectedItem;
        private decimal Quantity;

        public AddInvoiceScreen()
        {
            Invoice = new();
            InitializeComponent();
            ReloadCompanies();
            ReloadDGV();
        }

        private void ReloadCompanies()
        {
            foreach (Company company in Cloud.LoadClients())
            {
                cmbClients.Items.Add(company);
            }
        }

        private void ReloadDGV()
        {
            dgvInvoiceItems.Refresh();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.Rows.Count < 0 && cmbClients.SelectedIndex != -1)
            {
                //TODO Add invoice Save function Info.UploadInvoice(item);
            }
        }

        private void CmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudQuantity.Value = 0;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex > -1)
                SelectedItem = (Item)cmbItems.SelectedItem;
            Quantity = nudQuantity.Value;
            InvoiceItem invoiceItem = new(-1, SelectedItem, (int)Quantity, null);
            ReloadDGV();
        }

        private void CmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClients.SelectedIndex > -1)
                Invoice.Company = (Company)cmbClients.SelectedItem;
        }
    }
}
