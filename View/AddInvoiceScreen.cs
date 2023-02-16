using Entities;

namespace View
{
    public partial class AddInvoiceScreen : BaseForm
    {
        private Invoice Invoice;

        public AddInvoiceScreen()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            //TODO Load companies with client attribute true
            dgvInvoiceItems.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.Rows.Count < 0 && cmbClients.SelectedIndex != -1)
            {

            }
            //TODO Add invoice Save function Info.UploadInvoice(item);
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudQuantity.Value = 0;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)cmbItems.SelectedItem;
            decimal quantity = nudQuantity.Value;
            InvoiceItem invoiceItem = new(-1, selectedItem, (int)quantity, null);
            Reload();
        }
    }
}
