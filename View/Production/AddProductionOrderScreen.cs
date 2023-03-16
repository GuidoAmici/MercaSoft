using Control;
using Entities;

namespace View
{
    public partial class AddProductionOrderScreen : BaseForm
    {
        public AddProductionOrderScreen()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            foreach (Item item in Info.GetItemsForSale())
            {
                cmbItems.Items.Add(item);
                //BUG doesn't load items
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selectedItem = (Item)cmbItems.SelectedItem;
            List<Item> supplyList = Info.GetSupplies(selectedItem);
            int index;
            foreach (Item supply in supplyList)
            {
                index = dgvRequiredSupplies.NewRowIndex;

                dgvRequiredSupplies.Rows.Add(supply);
                dgvRequiredSupplies.Rows[index].Cells["Quantity"].Value = supply.SuppliedQuantity;
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            Item selectedItem = (Item)cmbItems.SelectedItem;
            List<Item> supplyList = Info.GetSupplies(selectedItem);
            int index;
            foreach (Item supply in supplyList)
            {
                index = dgvRequiredSupplies.NewRowIndex;

                dgvRequiredSupplies.Rows.Add(supply);
                dgvRequiredSupplies.Rows[index].Cells["Quantity"].Value = supply.SuppliedQuantity;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
