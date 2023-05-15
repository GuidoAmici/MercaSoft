using Control;

namespace View
{
    public partial class ProductionOrderHistoryScreen : BaseForm
    {
        BindingSource BSProductionOrders;
        public ProductionOrderHistoryScreen()
        {
            InitializeComponent();
            BSProductionOrders = new BindingSource
            {
                DataSource = Cloud.GetProductionOrders()
            };
            dgvProductionOrders.DataSource = BSProductionOrders;
        }
    }
}
