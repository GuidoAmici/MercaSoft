using Control;

namespace View
{
    public partial class LogInScreen : BaseForm
    {
        private string? Username;
        private string? Password;
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            Username = txtUser.Text;
            Password = txtPassword.Text;


            if (Username == String.Empty
                || Username == null)
            {
                MessageBox.Show("Ingrese el nombre usuario.");
                txtUser.Focus();
                return;
            }

            if (Password == String.Empty
                || Password == null)
            {
                MessageBox.Show("Ingrese la contraseña.");
                txtPassword.Focus();
                return;
            }

            Sesion.LogIn(Username, Password);
            if (Sesion.LogStatus())
            {
                Username = null;
                Password = null;
                Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUser.Focus();
            }
        }

        private void LblForgottenPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODOWHY Que pasa al hacer click en "Forgotten password?"
        }
    }
}
