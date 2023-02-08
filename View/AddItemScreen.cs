using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddItemScreen : Form
    {
        public AddItemScreen()
        {
            InitializeComponent();
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
    }
}
