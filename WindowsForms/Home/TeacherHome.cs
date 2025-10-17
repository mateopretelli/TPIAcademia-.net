using ApiClients;
using WindowsForms.TeacherPages;

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

        private void UploadGradesButton_Click(object sender, EventArgs e)
        {
            TeacherCourseList teacherCourses = new TeacherCourseList(this);
            teacherCourses.Show();
            this.Hide();
        }
    }
}
