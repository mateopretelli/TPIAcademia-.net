using DTOs;

namespace WindowsForms.FormTeacherCourse
{
    public partial class TeacherCourseList : Form
    {
        private AdminHome home;
        public TeacherCourseList(AdminHome home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void TeachersCourses_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void AddTeacherCourseButton_Click(object sender, EventArgs e)
        {
            TeacherCourseDetail courseDetail = new TeacherCourseDetail();

            TeacherCourseDTO courseDTO = new TeacherCourseDTO();

            courseDetail.TeacherCourse = courseDTO;

            courseDetail.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteTeacherCourseButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.SelectedItem().ID;
            await TeacherCourseApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void updateTeacherCourseButton_Click(object sender, EventArgs e)
        {
            TeacherCourseDetail courseDetail = new TeacherCourseDetail();

            int id;

            id = this.SelectedItem().ID;

            TeacherCourseDTO course = await TeacherCourseApiClient.GetAsync(id);

            courseDetail.EditMode = true;
            courseDetail.TeacherCourse = course;

            courseDetail.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            TeacherCourseApiClient client = new TeacherCourseApiClient();

            this.TeachersCoursesDataGridView.DataSource = null;
            this.TeachersCoursesDataGridView.DataSource = await TeacherCourseApiClient.GetAllAsync();

            if (this.TeachersCoursesDataGridView.Rows.Count > 0)
            {
                this.TeachersCoursesDataGridView.Rows[0].Selected = true;
                this.deleteTeacherCourseButton.Enabled = true;
                this.updateTeacherCourseButton.Enabled = true;
            }
            else
            {
                this.deleteTeacherCourseButton.Enabled = false;
                this.updateTeacherCourseButton.Enabled = false;
            }
        }

        private TeacherCourseDTO SelectedItem()
        {
            TeacherCourseDTO course;

            course = (TeacherCourseDTO)TeachersCoursesDataGridView.SelectedRows[0].DataBoundItem;

            return course;
        }

        private void TeacherCourseHomeButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

    }
}

