using DTOs;
using WindowsForms.FormSubject;
using WindowsForms.FormCourse;
using WindowsForms.FormUser;
using System.Threading.Tasks;

namespace WindowsForms.FormStudentCourse
{
    public partial class StudentCourseAdminDetail : Form
    {
        private Home home;

        private bool showingSubjects = true;

        private SubjectDTO? currentSubject = null;
        public StudentCourseAdminDetail(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void StudentCourseAdminDetail_Load(object sender, EventArgs e)
        {
            this.GetByCriteriaAndLoad();
            this.AddInscriptionButton.Enabled = false;
        }

        private void SearchCourseButton_Click(object sender, EventArgs e)
        {
            string searchText = this.CourseTextBox.Text.Trim();
            this.GetByCriteriaAndLoad(searchText);
        }

        private async void SelectButton_Click(object sender, EventArgs e)
        {
            if (showingSubjects)
            {
                var selectedRow = this.CourseGridView.SelectedRows[0];
                var selectedSubject = (SubjectDTO)selectedRow.DataBoundItem;
                currentSubject = selectedSubject;

                try
                {
                    var courses = await CourseApiClient.GetBySubjectIdAsync(selectedSubject.ID);
                    this.CourseGridView.DataSource = courses;

                    showingSubjects = false;
                    this.SelectButton.Text = "Volver a materias";
                    this.AddInscriptionButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los cursos de la materia seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.GetByCriteriaAndLoad();
                showingSubjects = true;
                currentSubject = null;
                this.SelectButton.Text = "Seleccionar materia";
                this.AddInscriptionButton.Enabled = false;
            }
        }

        private async void AddInscriptionButton_Click(object sender, EventArgs e)
        { 
           if (int.TryParse(LegajoTextBox.Text, out int legajo))
            {
                var selectedStudent = await UserApiClient.GetByLegajoAsync(legajo);
                var selectedRow = CourseGridView.SelectedRows[0];
                var selectedCourse = (CourseDTO)selectedRow.DataBoundItem;

                try
                {
                    await StudentCourseApiClient.AddAsync(selectedStudent.ID, selectedCourse.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al inscribir el alumno en el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido para el legajo.");
            }
        }

        private void LegajoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void GetByCriteriaAndLoad(string searchText = "")
        {
            try
            {
                this.CourseGridView.DataSource = null;

                IEnumerable<SubjectDTO> subjects;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    subjects = await SubjectApiClient.GetAllAsync();
                }
                else
                {
                    subjects = await SubjectApiClient.GetByCriteriaAsync(searchText);
                }

                this.CourseGridView.DataSource = subjects;

                if(this.CourseGridView.Rows.Count > 0)
                {
                    this.CourseGridView.Rows[0].Selected = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
