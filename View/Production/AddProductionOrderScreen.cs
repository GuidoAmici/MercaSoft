﻿using Control;
using Entities;

namespace View
{
    public partial class AddProductionOrderScreen : BaseForm
    {
        List<Item> SupplyList;
        BindingSource BSRequiredSupplies;

        public AddProductionOrderScreen()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            //Loads items into cmb
            foreach (Item item in Info.GetProducibleItems())
            {
                cmbItems.Items.Add(item);
            }


            BSRequiredSupplies = new BindingSource();
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reloads SupplyList with matching Item supplies
            if (cmbItems.SelectedIndex != -1)
            {
                nudQuantity.Enabled = true;

                Item selectedItem = (Item)cmbItems.SelectedItem;
                SupplyList = Info.GetProductionSupplies(selectedItem);

                //binds SupplyList to DGV through Binding Source
                BSRequiredSupplies.DataSource = SupplyList;
                dgvRequiredSupplies.DataSource = BSRequiredSupplies;
            }
            else
            {
                nudQuantity.Enabled = false;
            }
            nudQuantity.Value = 1;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            Item selectedItem = (Item)cmbItems.SelectedItem;
            SupplyList = Info.GetProductionSupplies(selectedItem);

            //binds SupplyList to DGV through Binding Source
            BSRequiredSupplies.DataSource = SupplyList;
            dgvRequiredSupplies.DataSource = BSRequiredSupplies;
            foreach (Item supply in SupplyList)
            {
                supply.SuppliedQuantity *= Convert.ToInt16(nudQuantity.Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
