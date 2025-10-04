using DTOs;

using WindowsForms.FormUser;

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
            UserLoginDTO userLoginDTO = new UserLoginDTO();
            userLoginDTO.Username = UserLoginTextBox.Text;
            userLoginDTO.Password = PwdLoginTextBox.Text;

            if (!ValidateLogin())
            {
                return;
            }
            LoginButton.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {

                bool loginSuccess = await UserApiClient.LoginAsync(userLoginDTO);
                if (loginSuccess)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                LoginButton.Enabled = true;
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
