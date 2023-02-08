using Control;

namespace View
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
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
            formInPanel = formsPanel.Controls.OfType<InsertedForm>().FirstOrDefault();

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
                formsPanel.Controls.Add(formInPanel);
                formsPanel.Tag = formInPanel;
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Sesion.LogOut();
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
    }
}