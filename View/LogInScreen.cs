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

            if (Username == String.Empty
                || Username == null)
            {
                MessageBox.Show("Ingrese el nombre usuario.");
                return;
            }

            if (Password == String.Empty
                || Password == null)
            {
                MessageBox.Show("Ingrese la contraseña.");
                return;
            }

            Sesion.LogIn(Username, Password);
            if (Sesion.LogStatus())
                Close();
            else MessageBox.Show("Credenciales incorrectas.");
        }

        private void lblForgottenPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO Que pasa al hacer click en "Forgotten password?"
        }
    }
}
