using ApiClients;

namespace WindowsForms.Home
{
    public partial class TeacherHome : Form
    {
        public TeacherHome()
        {
            InitializeComponent();
        }

        private async void TeacherLogoutButton_Click(object sender, EventArgs e)
        {
            var authService = AuthServiceProvider.Instance;
            await authService.LogoutAsync();
            Application.Restart();
        }
    }
}
