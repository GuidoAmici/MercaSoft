using Control;
using Entities;

namespace View
{
    public partial class AddItemScreen : BaseForm
    {
        public AddItemScreen()
        {
            InitializeComponent();
            Reload();

            SetSuppliesDgvVisibility(false);
        }

        private void Reload()
        {
            foreach (ItemCategory category in Cloud.GetCategories(true))
            {
                cmbCategories.Items.Add(category);
            }
        }

        private void SetSuppliesDgvVisibility(bool setter)
        {
            if (setter)
            {
                lblSupplyList.Visible = true;
                cmbSupplies.Visible = true;
                dgvAssociatedSupplies.Visible = true;
                lblDgvAssociatedSupplies.Visible = true;

                lblCodeName.Visible = false;
                txtCodeName.Visible = false;
                lblBarCode.Visible = false;
                txtBarCode.Visible = false;
                lblDescription.Visible = false;
                txtDescription.Visible = false;
            }
            else
            {
                lblSupplyList.Visible = false;
                cmbSupplies.Visible = false;
                dgvAssociatedSupplies.Visible = false;
                lblDgvAssociatedSupplies.Visible = false;

                lblCodeName.Visible = true;
                txtCodeName.Visible = true;
                lblBarCode.Visible = true;
                txtBarCode.Visible = true;
                lblDescription.Visible = true;
                txtDescription.Visible = true;
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

        private void ChkIsProducible_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsProducible.Checked)
            {
                btnAssociateSupplies.Visible = true;
            }
            else
            {
                btnAssociateSupplies.Visible = false;
            }

        }

        private void BtnAssociateSuppies_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedSupplies.Visible)
            {
                SetSuppliesDgvVisibility(false);
            }
            else
            {
                SetSuppliesDgvVisibility(true);
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

            if (txtItemName.Text != string.Empty
                && ((chkIsForSale.Checked && txtSalePrice.Text != string.Empty) || !chkIsForSale.Checked)
                )
            {
                Item item = new();
                Stock stock = new();

                item.ID = -1;
                item.Name = txtItemName.Text;
                item.IsProducible = chkIsProducible.Checked;
                item.IsForSale = chkIsForSale.Checked;
                item.Price = chkIsForSale.Checked ? Convert.ToSingle(txtSalePrice.Text) : 0;
                item.Stock = stock;
                item.ItemCategory = (ItemCategory)cmbCategories.SelectedItem;
                item.Description = txtDescription.Text;
                item.CodeName = txtCodeName.Text;
                item.BarCode = txtBarCode.Text == string.Empty ? null : Convert.ToInt16(txtBarCode.Text);

                Cloud.UploadItem(item);
            }
        }

        private void lblSupplies_Click(object sender, EventArgs e)
        {

        }
    }
}
