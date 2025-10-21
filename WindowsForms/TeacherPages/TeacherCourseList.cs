using APIAuthWindowsForms;
using DTOs;
using ApiClients;

namespace WindowsForms.TeacherPages
{
    public partial class TeacherCourseList : Form
    {
        private Form home;

        public TeacherCourseList(Form home)
        {
            InitializeComponent();
            LoadCourseListAsync();
            this.home = home;
        }

        private async void LoadCourseListAsync()
        {
            WindowsFormsAuthService authService = new WindowsFormsAuthService();
            UserDTO currentUser = await authService.GetCurrentUserAsync();
            this.TeacherCoursesLabel.Text = $"Lista de cursos del docente: {currentUser.Name} {currentUser.LastName}";
            IEnumerable<CourseDTO> courses = await TeacherCourseApiClient.GetByTeacherIdAsync(currentUser.ID);
            List<CourseDTO> courseList = courses.ToList();
            this.TeacherCoursesGrid.DataSource = courseList;

            if(this.TeacherCoursesGrid.Columns.Count > 0)
            {

                TeacherCoursesGrid.Columns["IDSection"].Visible = false;
                TeacherCoursesGrid.Columns["IDSubject"].Visible = false;
                TeacherCoursesGrid.Columns["Subject"].Visible = false;
                TeacherCoursesGrid.Columns["State"].Visible = false;

                TeacherCoursesGrid.Columns["SectionDescription"].HeaderText = "Comisión";
                TeacherCoursesGrid.Columns["SubjectDescription"].HeaderText = "Materia";
                TeacherCoursesGrid.Columns["AcademicYear"].HeaderText = "Año Académico";
                TeacherCoursesGrid.Columns["Capacity"].HeaderText = "Capacidad";

            }

            this.SelectCourseGradeButton.Enabled = this.TeacherCoursesGrid.Rows.Count > 0;

        }

        private void CoursesByTeacherBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void SelectCourseGradeButton_Click(object sender, EventArgs e)
        {
            CourseDTO selectedCourse = (CourseDTO)TeacherCoursesGrid.SelectedRows[0].DataBoundItem;

            int courseID = selectedCourse.ID;

            string courseTitle = selectedCourse.SubjectDescription + " - " + selectedCourse.SectionDescription + " - " + selectedCourse.AcademicYear;

            CourseDetail courseDetailForm = new CourseDetail(courseID, courseTitle);

            courseDetailForm.Show();
        }
    }
}
