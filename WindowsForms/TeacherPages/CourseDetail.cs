using ApiClients;
using DTOs;
using WindowsForms.TeacherPages;

namespace WindowsForms.TeacherPages
{
    public partial class CourseDetail : Form
    {
        private int courseID;
        public CourseDetail(int selectedCourseID, string CourseTitle)
        {
            InitializeComponent();
            courseID = selectedCourseID;
            LoadCourseInfo(courseID);
            this.CourseDetailInfoLabel.Text = CourseTitle;
        }

        private async void LoadCourseInfo(int id)
        {
            IEnumerable<StudentCourseDetailDTO> courseInfo = await StudentCourseApiClient.GetDetailsByCourseIdAsync(id);
            CourseDetailinfoGrid.DataSource = courseInfo.ToList();

            if (CourseDetailinfoGrid.Columns.Count > 0)
            {
                CourseDetailinfoGrid.Columns["ID"].Visible = false;
                CourseDetailinfoGrid.Columns["IDStudent"].Visible = false;
                CourseDetailinfoGrid.Columns["State"].Visible = false;

                CourseDetailinfoGrid.Columns["StudentName"].HeaderText = "Nombre";
                CourseDetailinfoGrid.Columns["StudentLastName"].HeaderText = "Apellido";
                CourseDetailinfoGrid.Columns["StudentEmail"].HeaderText = "Email";
                CourseDetailinfoGrid.Columns["Grade"].HeaderText = "Nota";
                CourseDetailinfoGrid.Columns["Condition"].HeaderText = "Condición";

                this.SelectStudentButton.Enabled = true;
                this.CourseReportButton.Enabled = true;
            }

        }

        private void SelectStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                StudentCourseDetail studentCourseDetail = new StudentCourseDetail(GetSelectedStudentCourseID());
                studentCourseDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el detalle del alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCourseInfo(courseID);
        }

        private int GetSelectedStudentCourseID()
        {
            if (CourseDetailinfoGrid.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(CourseDetailinfoGrid.SelectedRows[0].Cells["ID"].Value);
            }
            else
            {
                throw new Exception("No se ha seleccionado ningún alumno.");
            }
        }

        private void CourseDetailBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseReportButton_Click(object sender, EventArgs e)
        {
            CourseReport courseReport = new CourseReport(courseID, CourseDetailInfoLabel.Text);
            courseReport.ShowDialog();
        }
    }
}
