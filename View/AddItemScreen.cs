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
        }

        private void Reload()
        {
            foreach (Category category in Info.GetCategories(true))
            {
                cmbCategories.Items.Add(category);
            }
        }

        private void chkIsForSale_CheckedChanged(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
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
