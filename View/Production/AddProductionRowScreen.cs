using Data;
using Entities;

namespace View
{
    public partial class AddProductionRowScreen : BaseForm
    {
        List<ProductionOrder> ProductionOrders;
        public AddProductionRowScreen()
        {
            InitializeComponent();

            ProductionOrders = ProductionOrderDAO.GetAll();
            ReloadComponents();
        }

        private void ReloadComponents()
        {
            cmbItem.DataSource = ProductionOrders;
        }
    }
}
