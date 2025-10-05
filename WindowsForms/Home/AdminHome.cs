using WindowsForms.FormCourse;
using WindowsForms.FormSection;
using WindowsForms.FormTeacherCourse;

namespace WindowsForms

{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();

        }

        private void MateriasButton_Click(object sender, EventArgs e)
        {
            SubjectsList materiasLista = new SubjectsList(this);
            materiasLista.Show();
            this.Hide();
        }

        private void PlanesButton_Click(object sender, EventArgs e)
        {
            PlansList planesLista = new PlansList(this);
            planesLista.Show();
            this.Hide();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserList usersLista = new UserList(this);
            usersLista.Show();
            this.Hide();
        }

        private void SpecialtiesButton_Click(object sender, EventArgs e)
        {
            SpecialtiesList specialtiesLista = new SpecialtiesList(this);
            specialtiesLista.Show();
            this.Hide();
        }
        private void SectionsButton_Click(object sender, EventArgs e)
        {
            SectionList sectionList = new SectionList(this);
            sectionList.Show();
            this.Hide();
        }
        private void CoursesButton_Click(object sender, EventArgs e)
        {
            CourseList courseList = new CourseList(this);
            courseList.Show();
            this.Hide();
        }
        private void TeachersCoursesButton_Click(object sender, EventArgs e)
        {
            TeacherCourseList teachercourseList = new TeacherCourseList(this);
            teachercourseList.Show();
            this.Hide();
        }
    }
}
