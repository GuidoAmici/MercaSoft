using Control;
using Entities;

namespace View
{
    public partial class AddInvoiceScreen : BaseForm
    {
        public AddInvoiceScreen()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            //TODO Load companies with client attribute true
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            //TODO Add invoice Save function Info.UploadInvoice(item);
        }
    }
}
