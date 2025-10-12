using ApiClients;

namespace WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {

            if (!ValidateLogin())
            {
                return;
            }
            UserLoginTextBox.Enabled = false;
            PwdLoginTextBox.Enabled = false;
            LoginButton.Enabled = false;
            LoginButton.Text="Iniciando sesión...";
            this.Cursor = Cursors.WaitCursor;
            try
            {

                var authService = AuthServiceProvider.Instance;
                bool success = await authService.LoginAsync(UserLoginTextBox.Text, PwdLoginTextBox.Text);
                if (success)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PwdLoginTextBox.Clear();
                    PwdLoginTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                UserLoginTextBox.Enabled = true;
                PwdLoginTextBox.Enabled = true;
                LoginButton.Enabled = true;
                LoginButton.Text = "Iniciar Sesión";
            }
            
        }

        private bool ValidateLogin()
        {
            LoginErrorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(UserLoginTextBox.Text))
            {
                isValid = false;
                LoginErrorProvider.SetError(UserLoginTextBox, "El nombre es requerido");
            }
            if (string.IsNullOrWhiteSpace(PwdLoginTextBox.Text))
            {
                isValid = false;
                LoginErrorProvider.SetError(PwdLoginTextBox, "La contraseña es requerida");
            }
            return isValid;
        }
    }
}
