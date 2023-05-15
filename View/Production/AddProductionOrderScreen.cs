using Control;
using Entities;

namespace View
{
    public partial class AddProductionOrderScreen : BaseForm
    {
        ProductionOrder ProductionOrder;

        List<Item> SupplyList;
        BindingSource BSRequiredSupplies;

        public AddProductionOrderScreen()
        {
            InitializeComponent();
            ProductionOrder = new();
            Reload();
        }

        private void Reload()
        {
            //Loads items into cmb
            foreach (Item item in Cloud.GetProducibleItems())
            {
                cmbItems.Items.Add(item);
            }


            BSRequiredSupplies = new BindingSource();
        }

        private void CmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reloads SupplyList with matching Item supplies
            if (cmbItems.SelectedIndex != -1)
            {
                nudQuantity.Enabled = true;

                ProductionOrder.Item = (Item)cmbItems.SelectedItem;
                SupplyList = Cloud.GetProductionSupplies(ProductionOrder.Item);

                //binds SupplyList to DGV through Binding Source
                BSRequiredSupplies.DataSource = SupplyList;
                dgvRequiredSupplies.DataSource = BSRequiredSupplies;
            }
            else
            {
                MessageBox.Show(cmbItems.SelectedIndex.ToString());
                nudQuantity.Enabled = false;
            }
            nudQuantity.Value = 1;
        }

        private void NudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex != -1)
            {
                ProductionOrder.Quantity = Convert.ToInt16(nudQuantity.Value);
                ProductionOrder.Item = (Item)cmbItems.SelectedItem;
                SupplyList = Cloud.GetProductionSupplies(ProductionOrder.Item);

                //binds SupplyList to DGV through Binding Source
                BSRequiredSupplies.DataSource = SupplyList;
                dgvRequiredSupplies.DataSource = BSRequiredSupplies;
                foreach (Item supply in SupplyList)
                {
                    supply.SuppliedQuantity *= Convert.ToInt16(nudQuantity.Value);
                }
            }
            else
            {
                nudQuantity.Enabled = false;
                nudQuantity.Value = 1;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex != -1)
            {
                Cloud.SubmitProductionOrder(ProductionOrder, SupplyList);
            }
            MessageBox.Show($"Orden de producción Nº {ProductionOrder.ID} creada");
            this.Close();
        }
    }
}
