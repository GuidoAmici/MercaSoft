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
            Form formInPanel;
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
                formInPanel = new InsertedForm();
                formInPanel.TopLevel = false;
                formInPanel.FormBorderStyle = FormBorderStyle.None;
                formInPanel.Dock = DockStyle.Fill;
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
            List<Form> forms = new List<Form>();

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Sesion.LogOut();
            CloseOpenForms();
            Reload();
        }

        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.LogOut();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<AddItemScreen>();
        }

        private void menuDashboard_Click(object sender, EventArgs e)
        {
            InsertIntoPanel<DashboardScreen>();
        }

        private void submenuCheckInventory_Click(object sender, EventArgs e)
        {

        }
    }
}