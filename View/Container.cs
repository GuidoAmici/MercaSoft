namespace View
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Reload(object sender, EventArgs e)
        {
            if (Program.Logged == false)
            {
                sidePanel.Visible = false;
                InsertIntoPanel<Login>();
            }
            else
            {
                sidePanel.Visible = true;
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
            }
        }

        private void FormInPanel_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}