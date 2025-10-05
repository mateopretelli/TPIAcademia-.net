using DTOs;

namespace WindowsForms.FormCourse
{
    public partial class CourseList : Form
    {
        private AdminHome home;
        public CourseList(AdminHome home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            CourseDetail courseDetail = new CourseDetail();

            CourseDTO courseDTO = new CourseDTO();

            courseDetail.Course = courseDTO;

            courseDetail.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteCourseButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.SelectedItem().ID;
            await CourseApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void updateCourseButton_Click(object sender, EventArgs e)
        {
            CourseDetail courseDetail = new CourseDetail();

            int id;

            id = this.SelectedItem().ID;

            CourseDTO course = await CourseApiClient.GetAsync(id);

            courseDetail.EditMode = true;
            courseDetail.Course = course;

            courseDetail.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            CourseApiClient client = new CourseApiClient();

            this.CoursesDataGridView.DataSource = null;
            this.CoursesDataGridView.DataSource = await CourseApiClient.GetAllAsync();

            if (this.CoursesDataGridView.Rows.Count > 0)
            {
                this.CoursesDataGridView.Rows[0].Selected = true;
                this.deleteCourseButton.Enabled = true;
                this.updateCourseButton.Enabled = true;
            }
            else
            {
                this.deleteCourseButton.Enabled = false;
                this.updateCourseButton.Enabled = false;
            }
        }

        private CourseDTO SelectedItem()
        {
            CourseDTO course;

            course = (CourseDTO)CoursesDataGridView.SelectedRows[0].DataBoundItem;

            return course;
        }

        private void CourseHomeButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

    }
}

