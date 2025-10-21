using APIAuthWindowsForms;
using ApiClients;
using DTOs;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsForms.FormStudentCourse
{
    public partial class StudentCourseDetail : Form
    {
        private Form home;

        private bool showingSubjects = true;

        private SubjectDTO? currentSubject = null;

        private string userType = "";

        private int? userPlanId;

        public StudentCourseDetail(Form home)
        {
            InitializeComponent();
            this.home = home;
            SetUserType();
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
                    MessageBox.Show($"El alumno {selectedStudent.Name} fue inscripto exitosamente en el curso.",
                    "Inscripción Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    // Limpiar el textbox o refrescar la vista
                    LegajoTextBox.Clear();
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

                if(userType == "Student")
                {
                    subjects = subjects.Where(s => s.IDPlan == userPlanId).ToList();
                }

                this.CourseGridView.DataSource = subjects;

                if (this.CourseGridView.Rows.Count > 0)
                {
                    this.CourseGridView.Rows[0].Selected = true;

                    this.CourseGridView.Columns["State"].Visible = false;
                    this.CourseGridView.Columns["Plan"].Visible = false;
                    this.CourseGridView.Columns["Description"].HeaderText = "Descripcion";
                    this.CourseGridView.Columns["WeeklyHS"].HeaderText = "HSSemanales";
                    this.CourseGridView.Columns["TotalHS"].HeaderText = "HSTotales";

                }
                else
                {
                    this.AddInscriptionButton.Enabled = false;
                    this.SelectButton.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentCouseHomeButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private async void SetUserType()
        {
            try
            {
                var authService = new WindowsFormsAuthService();
                userType = await authService.GetUserRoleAsync();
                if (userType != "Admin" && userType != "Student")
                {
                    MessageBox.Show("No tiene permisos para acceder a esta sección.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                else if (userType == "Student")
                {
                    var currentUser = await authService.GetCurrentUserAsync();
                    SetFormForStudent(currentUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al determinar el rol del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SetFormForStudent(UserDTO currentUser)
        {
            LegajoTextBox.Text = currentUser.Legajo.ToString();
            LegajoTextBox.Enabled = false;
            userPlanId = currentUser.IDPlan;
        }
    }
}
