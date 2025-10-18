using ApiClients;
using WindowsForms.FormStudentCourse;
using WindowsForms.StudentPages;

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

        private void StudentSubjectsPlanButton_Click(object sender, EventArgs e)
        {
            PlanSubjects planSubjects = new PlanSubjects(this);
            planSubjects.Show();
            this.Hide();
        }

        private void StudentSubjectsGradeButton_Click(object sender, EventArgs e)
        {
            StudentCourseGrades studentCourseGrades = new StudentCourseGrades(this);
            studentCourseGrades.Show();
            this.Hide();
        }
    }
}
