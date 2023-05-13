﻿using Control;
using Entities;

namespace View
{
    public partial class AddItemScreen : BaseForm
    {
        public AddItemScreen()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            foreach (ItemCategory category in Info.GetCategories(true))
            {
                cmbCategories.Items.Add(category);
            }
        }

        private void ChkIsForSale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsForSale.Checked)
            {
                lblSalePrice.Visible = true;
                txtSalePrice.Visible = true;
            }
            else
            {
                lblSalePrice.Visible = false;
                txtSalePrice.Visible = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //TODO Add dgv for related supplies to the item
            if (txtItemName.Text == string.Empty)
            {
                txtItemName.Focus();
                return;
            }

            if (cmbCategories.SelectedIndex == -1)
            {
                cmbCategories.DroppedDown = true;
                return;
            }

            if (txtItemName.Text != string.Empty
                && ((chkIsForSale.Checked && txtSalePrice.Text != string.Empty) || chkIsForSale.Checked)
                )
            {
                /*
                Item item = new Item(
                    -1,
                    txtItemName.Text,
                    chkIsForSale.Checked,
                    txtSalePrice.Text,
                    cmbCategories.SelectedItem,
                    txtDescription.Text,
                    txtCodeName.Text,
                    txtBarCode.Text
                    );
                Info.UploadItem(item);
                */
            }
        }
    }
}
