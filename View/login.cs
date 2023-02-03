namespace View
{
    public partial class LogIn : Form
    {
        private string User;
        private string Password;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User = txtUser.Text;
            Password = txtPassword.Text;

            Program.Logged = Control.User.LogIn(User, Password);
            Close();
        }

        private void lblForgottenPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO Que pasa al hacer click en "Forgotten password?"
        }
    }
}
