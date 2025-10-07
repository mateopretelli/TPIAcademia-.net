using DTOs;
using WindowsForms.FormPlans;
using WindowsForms.FormSection;
using WindowsForms.FormSubject;
using WindowsForms.FormSpecialty;
using WindowsForms.FormCourse;
using WindowsForms.FormUser;
using System.Diagnostics;

namespace WindowsForms.FormTeacherCourse
{
    public partial class TeacherCourseDetail : Form
    {
        private TeacherCourseDTO teachercourse;

        private IEnumerable<CourseDTO> Courses { get; set; }

        private IEnumerable<UserDTO> Teachers { get; set; }

        private IEnumerable<SectionDTO> Sections { get; set; }

        private IEnumerable<SubjectDTO> Subjects { get; set; }

        private IEnumerable<PlanDTO> Plans { get; set; }

        private IEnumerable<SpecialtyDTO> Specialties { get; set; }

        public CourseDTO Course { get; set; }
        public SubjectDTO Subject { get; set; }
        public PlanDTO Plan { get; set; }
        public SpecialtyDTO Specialty { get; set; }

        public TeacherCourseDTO TeacherCourse
        {
            get { return teachercourse; }
            set
            {
                teachercourse = value;
                this.SetTeacherCourse();
            }
        }

        public bool EditMode { get; set; } = false;

        public TeacherCourseDetail()
        {
            InitializeComponent();

            TeacherCourseRoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeacherCourseRoleComboBox.DataSource = new List<string> { "Titular", "Ayudante"};
        }

        private async void acceptTeacherCourseButton_Click(object sender, EventArgs e)
        {
            IEnumerable<TeacherCourseDTO> existingTeacherCourses = await TeacherCourseApiClient.GetAllAsync();

            if (this.ValidateTeacherCourse(existingTeacherCourses))
            {
                this.TeacherCourse.Role = Convert.ToInt32(TeacherCourseRoleComboBox.SelectedIndex)+1;
                this.TeacherCourse.IDCourse = Convert.ToInt32(CourseTeacherCourseComboBox.SelectedValue);
                this.TeacherCourse.IDTeacher = Convert.ToInt32(TeacherTeacherCourseComboBox.SelectedValue);

                try
                {
                    if (this.EditMode)
                    {
                        await TeacherCourseApiClient.UpdateAsync(this.TeacherCourse);
                    }
                    else
                    {
                        await TeacherCourseApiClient.AddAsync(this.TeacherCourse);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar un docente a un curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }

        private void cancelTeacherCourseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidDescription(int role, IEnumerable<TeacherCourseDTO> teacherscourses)
        {
            if (role == this.teachercourse.Role)
            {
                return false; // Si no cambió, no es necesario validar
            }
            else
            {
                var foundedTeacherCourse = from TeacherCourseDTO tc in teacherscourses
                                           where
                                           tc.Role == role
                                           && tc.IDCourse == this.TeacherCourse.IDCourse
                                           && tc.IDTeacher == this.TeacherCourse.IDTeacher
                                           && tc.State == "Active"
                                           select tc;

                return foundedTeacherCourse.Any();
            }
        }

        private async void SetTeacherCourse()
        {
            Specialties = await SpecialtyApiClient.GetAllAsync();
            Plans = await PlanApiClient.GetAllAsync();
            Subjects = await SubjectApiClient.GetAllAsync();
            Sections = await SectionApiClient.GetAllAsync();
            Courses = await CourseApiClient.GetAllAsync();
            Teachers = await UserApiClient.GetAllPerTypeAsync(2);

            TeacherTeacherCourseComboBox.DataSource = Teachers;
            TeacherTeacherCourseComboBox.DisplayMember = "FullNameLegajo";
            TeacherTeacherCourseComboBox.ValueMember = "ID";

            TeacherCourseIDTextBox.Text = this.TeacherCourse.ID.ToString();
            TeacherCourseStateTextBox.Text = this.TeacherCourse.State;
            if (this.TeacherCourse.Role == 0) {
                TeacherCourseRoleComboBox.SelectedItem = "Titular";
            } else {
                TeacherCourseRoleComboBox.SelectedIndex = this.TeacherCourse.Role - 1;
            };
            SpecialtyTeacherCourseComboBox.DataSource = Specialties;
            SpecialtyTeacherCourseComboBox.DisplayMember = "Description";
            SpecialtyTeacherCourseComboBox.ValueMember = "ID";
        }

        private bool ValidateTeacherCourse(IEnumerable<TeacherCourseDTO> existingTeacherCourses)
        {
            bool isValid = true;

            // Validar Role
            if (ValidDescription((Convert.ToInt32(TeacherCourseRoleComboBox.SelectedIndex) + 1), existingTeacherCourses))
            {
                isValid = false;
                TeacherCourseErrorProvider.SetError(TeacherCourseRoleComboBox, "Ya existe un docente en ese año curso con ese rol");
            }
            else
            {
                TeacherCourseErrorProvider.SetError(TeacherCourseRoleComboBox, string.Empty);
            }

            // Validar IDTeacher
            if (TeacherTeacherCourseComboBox.SelectedValue == null)
            {
                isValid = false;
                TeacherCourseErrorProvider.SetError(TeacherTeacherCourseComboBox, "El docente es requerido");
            }
            else
            {
                TeacherCourseErrorProvider.SetError(TeacherTeacherCourseComboBox, string.Empty);
            }

            // Validar IDCourse
            if (CourseTeacherCourseComboBox.SelectedValue == null)
            {
                isValid = false;
                TeacherCourseErrorProvider.SetError(CourseTeacherCourseComboBox, "El curso es requerido");
            }
            else
            {
                TeacherCourseErrorProvider.SetError(CourseTeacherCourseComboBox, string.Empty);
            }


            return isValid;
        }

        private void SpecialtyTeacherCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpecialtyTeacherCourseComboBox.SelectedValue != null)
            {
                //consigo ID de especialidad seleccionada
                int selectedSpecialtyId = ((SpecialtyDTO)SpecialtyTeacherCourseComboBox.SelectedItem).ID;

                // Filtrar planes por specialty
                var filteredPlans = Plans
                    .Where(p => p.IDSpecialty == selectedSpecialtyId)
                    .ToList();

                PlanTeacherCourseComboBox.DataSource = filteredPlans;
                PlanTeacherCourseComboBox.DisplayMember = "Description";
                PlanTeacherCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                PlanTeacherCourseComboBox.Enabled = filteredPlans.Count > 0;
            }

        }

        private void PlanTeacherCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlanTeacherCourseComboBox.SelectedValue != null)
            {
                //consigo ID de especialidad seleccionada
                int selectedPlanId = ((PlanDTO)PlanTeacherCourseComboBox.SelectedItem).ID;

                // Filtrar comisiones por plan
                var filteredSections = Sections
                    .Where(p => p.IDPlan == selectedPlanId)
                    .ToList();

                SectionTeacherCourseComboBox.DataSource = filteredSections;
                SectionTeacherCourseComboBox.DisplayMember = "Description";
                SectionTeacherCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                SectionTeacherCourseComboBox.Enabled = filteredSections.Count > 0;

                //lo mismo pero para subject

                // Filtrar materias por plan
                var filteredSubjects = Subjects
                    .Where(p => p.IDPlan == selectedPlanId)
                    .ToList();

                SubjectTeacherCourseComboBox.DataSource = filteredSubjects;
                SubjectTeacherCourseComboBox.DisplayMember = "Description";
                SubjectTeacherCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                SubjectTeacherCourseComboBox.Enabled = filteredSubjects.Count > 0;
            }
        }

        private void Subject_Section_TeacherCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectTeacherCourseComboBox.SelectedValue != null && SectionTeacherCourseComboBox.SelectedValue != null)
            {
                //consigo ID de subject y section seleccionados
                int selectedSectionId = ((SectionDTO)SectionTeacherCourseComboBox.SelectedItem).ID;
                int selectedSubjectId = ((SubjectDTO)SubjectTeacherCourseComboBox.SelectedItem).ID;

                // Filtrar courses por subject y section
                var filteredCourses = Courses
                    .Where(c => c.IDSubject == selectedSubjectId && c.IDSection == selectedSectionId)
                    .ToList();

                CourseTeacherCourseComboBox.DataSource = filteredCourses;
                CourseTeacherCourseComboBox.DisplayMember = "ID";
                CourseTeacherCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                CourseTeacherCourseComboBox.Enabled = filteredCourses.Count > 0;
            }

        }
    }
}
