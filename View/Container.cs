using Control;

namespace View
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            InsertIntoPanel<DashboardScreen>();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            if (Sesion.LogStatus())
            {
                menuStrip.Visible = true;
            }
            else
            {
                menuStrip.Visible = false;
                InsertIntoPanel<LogInScreen>();
            }
        }

        private void InsertIntoPanel<InsertedForm>() where InsertedForm : Form, new()
        {
            InsertedForm? formInPanel;
            formInPanel = mainPanel.Controls.OfType<InsertedForm>().FirstOrDefault();

            if (formInPanel != null)
            {
                formInPanel.BringToFront();
                if (formInPanel.WindowState == FormWindowState.Minimized)
                {
                    formInPanel.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                formInPanel = new InsertedForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                mainPanel.Controls.Add(formInPanel);
                mainPanel.Tag = formInPanel;
                formInPanel.Show();

                formInPanel.BringToFront();
                formInPanel.FormClosed += new FormClosedEventHandler(MainPanelFormClosed);
            }
        }

        private void MainPanelFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["LogIn"] == null)
            {
                Reload();
            }
        }

        private void CloseOpenForms()
        {
            List<Form> forms = new();

            foreach (Form form in Application.OpenForms)
            {
                if (!form.Equals(this))
                {
                    forms.Add(form);
                }
            }

            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Sesion.LogOut();
            CloseOpenForms();
            Reload();
        }

        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.LogOut();
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<AddItemScreen>();
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<DashboardScreen>();
        }

        private void SubmenuCheckInventory_Click(object sender, EventArgs e)
        {

        }

        private void SubmenuAddSale_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<AddInvoiceScreen>();
        }

        private void SubmenuSalesHistory_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<InvoiceHistoryScreen>();
        }

        private void SubmenuAddProductionOrder_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<AddProductionOrderScreen>();
        }

        private void SubmenuProductionOrderHistory_Click(object sender, EventArgs e)
        {

        }

        private void SubmenuAddProductionRow_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<AddProductionRowScreen>();
        }
    }
}