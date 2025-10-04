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
            UserDTO userDTO = new UserDTO();

            this.Cursor = Cursors.WaitCursor;
            try
            {
                userDTO = await UserApiClient.GetByUsernameAsync(UserLoginTextBox.Text);

                if (userDTO != null)
                {
                    if (userDTO.Password == PwdLoginTextBox.Text)
                    {
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }
    }
}
