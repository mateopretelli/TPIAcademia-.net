using ApiClients;
using WindowsForms.FormStudentCourse;

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

        private void StudentInscriptionButton_Click(object sender, EventArgs e)
        {
            StudentCourseDetail studentCourseDetail = new StudentCourseDetail(this);
            studentCourseDetail.Show();
            this.Hide();

        }
    }
}
