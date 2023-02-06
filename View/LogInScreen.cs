using Control;

namespace View
{
    public partial class LogInScreen : Form
    {
        private string? Username;
        private string? Password;
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Username = txtUser.Text;
            Password = txtPassword.Text;

            Sesion.LogIn(Username, Password);
            Close();
        }

        private void lblForgottenPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO Que pasa al hacer click en "Forgotten password?"
        }
    }
}
