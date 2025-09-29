using DTOs;
using WindowsForms.FormPlans;
using WindowsForms.FormSection;
using WindowsForms.FormSubject;
using WindowsForms.FormSpecialty;
using System.Diagnostics;

namespace WindowsForms.FormCourse
{
    public partial class CourseDetail : Form
    {
        private CourseDTO course;

        private IEnumerable<SectionDTO> Sections { get; set; }

        private IEnumerable<SubjectDTO> Subjects { get; set; }

        private IEnumerable<PlanDTO> Plans { get; set; }

        private IEnumerable<SpecialtyDTO> Specialties { get; set; }

        public PlanDTO Plan { get; set; }
        public SubjectDTO Subject { get; set; }
        public SpecialtyDTO Specialty { get; set; }

        public CourseDTO Course
        {
            get { return course; }
            set
            {
                course = value;
                this.SetCourse();
            }
        }

        public bool EditMode { get; set; } = false;

        public CourseDetail()
        {
            InitializeComponent();
        }

        private async void acceptCourseButton_Click(object sender, EventArgs e)
        {
            IEnumerable<CourseDTO> existingCourses = await CourseApiClient.GetAllAsync();

            if (this.ValidateCourse(existingCourses))
            {
                this.Course.AcademicYear = int.Parse(CourseAcademicYearTextBox.Text);
                this.Course.IDSection = Convert.ToInt32(SectionCourseComboBox.SelectedValue);
                this.Course.IDSubject = Convert.ToInt32(SubjectCourseComboBox.SelectedValue);
                this.Course.Capacity = int.Parse(CourseCapacityTextBox.Text);

                try
                {
                    if (this.EditMode)
                    {
                        await CourseApiClient.UpdateAsync(this.Course);
                    }
                    else
                    {
                        await CourseApiClient.AddAsync(this.Course);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.Close();
            }
        }

        private void cancelCourseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidDescription(int academicYear,int capacity, IEnumerable<CourseDTO> courses)
        {
            if (capacity == this.course.Capacity && academicYear == this.Course.AcademicYear)
            {
                return false; // Si no cambió, no es necesario validar
            }
            else
            {
                var foundedCourse = from CourseDTO c in courses
                                    where c.AcademicYear == academicYear
                                    && c.Capacity == capacity
                                    && c.IDSubject == this.Course.IDSubject
                                    && c.IDSection == this.Course.IDSection
                                    && c.State == "Active"
                                    select c;

                return foundedCourse.Any();
            }
        }

        private async void SetCourse()
        {
            Specialties = await SpecialtyApiClient.GetAllAsync();
            Plans = await PlanApiClient.GetAllAsync();
            Subjects = await SubjectApiClient.GetAllAsync();
            Sections = await SectionApiClient.GetAllAsync();

            CourseIDTextBox.Text = this.Course.ID.ToString();
            CourseCapacityTextBox.Text = this.Course.Capacity.ToString();
            CourseAcademicYearTextBox.Text = this.Course.AcademicYear.ToString();
            CourseStateTextBox.Text = this.Course.State;

            SpecialtyCourseComboBox.SelectedValue = this.Subject?.Plan.SpecialtyDescription;
            SpecialtyCourseComboBox.DataSource = Specialties;
            SpecialtyCourseComboBox.DisplayMember = "Description";
            SpecialtyCourseComboBox.ValueMember = "ID";
        }

        private bool ValidateCourse(IEnumerable<CourseDTO> existingCourses)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(this.CourseAcademicYearTextBox.Text))
            {
                isValid = false;
                CourseErrorProvider.SetError(CourseAcademicYearTextBox, "El año académico es requerido");
            }
            else if (ValidDescription(int.Parse(this.CourseAcademicYearTextBox.Text), int.Parse(this.CourseCapacityTextBox.Text), existingCourses))
            {
                isValid = false;
                CourseErrorProvider.SetError(CourseAcademicYearTextBox, "Ya existe un curso en ese año académico en la misma materia y comisión");
            }
            else
            {
                CourseErrorProvider.SetError(CourseAcademicYearTextBox, string.Empty);
            }

            if (CourseCapacityTextBox.Text == null)
            {
                isValid = false;
                CourseErrorProvider.SetError(CourseCapacityTextBox, "La capacidad del curso es requerida");
            }
            else
            {
                CourseErrorProvider.SetError(CourseCapacityTextBox, string.Empty);
            }

            // Validar ID Subject
            if (SubjectCourseComboBox.SelectedValue == null)
            {
                isValid = false;
                CourseErrorProvider.SetError(SubjectCourseComboBox, "La materia es requerida");
            }
            else
            {
                CourseErrorProvider.SetError(SubjectCourseComboBox, string.Empty);
            }

            // Validar ID Section
            if (SectionCourseComboBox.SelectedValue == null)
            {
                isValid = false;
                CourseErrorProvider.SetError(SectionCourseComboBox, "La comisión es requerida");
            }
            else
            {
                CourseErrorProvider.SetError(SectionCourseComboBox, string.Empty);
            }


            return isValid;
        }

        private void SpecialtyCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpecialtyCourseComboBox.SelectedValue != null)
            {
                //consigo ID de especialidad seleccionada
                int selectedSpecialtyId = ((SpecialtyDTO)SpecialtyCourseComboBox.SelectedItem).ID;

                // Filtrar planes por specialty
                var filteredPlans = Plans
                    .Where(p => p.IDSpecialty == selectedSpecialtyId)
                    .ToList();

                PlanCourseComboBox.DataSource = filteredPlans;
                PlanCourseComboBox.DisplayMember = "Description";
                PlanCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                PlanCourseComboBox.Enabled = filteredPlans.Count > 0;
            }

        }

        private void PlanCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlanCourseComboBox.SelectedValue != null)
            {
                //consigo ID de especialidad seleccionada
                int selectedPlanId = ((PlanDTO)PlanCourseComboBox.SelectedItem).ID;

                // Filtrar planes por specialty
                var filteredSections = Sections
                    .Where(p => p.IDPlan == selectedPlanId)
                    .ToList();

                SectionCourseComboBox.DataSource = filteredSections;
                SectionCourseComboBox.DisplayMember = "Description";
                SectionCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                SectionCourseComboBox.Enabled = filteredSections.Count > 0;

                //lo mismo pero para subject

                // Filtrar planes por specialty
                var filteredSubjects = Subjects
                    .Where(p => p.IDPlan == selectedPlanId)
                    .ToList();

                SubjectCourseComboBox.DataSource = filteredSubjects;
                SubjectCourseComboBox.DisplayMember = "Description";
                SubjectCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                SubjectCourseComboBox.Enabled = filteredSubjects.Count > 0;
            }

        }

    }
}
