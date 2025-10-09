using ApiClients;

namespace WindowsForms.Home
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private async void AdminLogoutButton_Click(object sender, EventArgs e)
        {
            var authService = AuthServiceProvider.Instance;
            await authService.LogoutAsync();
            Application.Restart();
        }
    }
}
