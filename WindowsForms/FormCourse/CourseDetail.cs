using DTOs;
using WindowsForms.FormPlans;
using WindowsForms.FormSection;
using WindowsForms.FormSubject;
using WindowsForms.FormSpecialty;

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
                this.Course.IDSection = Convert.ToInt32(IDSectionCourseComboBox.SelectedValue);
                this.Course.IDSubject = Convert.ToInt32(IDSubjectCourseComboBox.SelectedValue);
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


        private bool ValidDescription(string descripcion, IEnumerable<CourseDTO> courses)
        {
            if (descripcion == this.Course.Description)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }
            else
            {
                var foundedCourse = from CourseDTO s in courses
                                     where s.Description == descripcion &&
                                     s.IDPlan == this.Course.IDPlan
                                     && s.SectionYear == this.Course.SectionYear
                                     && s.State == "Active"
                                     select s;

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

            SpecialtiesCourseComboBox.SelectedValue = this.Subject.Plan.SpecialtyDescription;
            SpecialtiesCourseComboBox.DataSource = Specialties;
            SpecialtiesCourseComboBox.DisplayMember = "Description";
            SpecialtiesCourseComboBox.ValueMember = "ID";
        }

        private bool ValidateCourse(IEnumerable<CourseDTO> existingCourses)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(this.CourseDescriptionTextBox.Text))
            {
                isValid = false;
                CourseErrorProvider.SetError(CourseDescriptionTextBox, "La descripción es requerida");
            }
            else if (ValidDescription(this.CourseDescriptionTextBox.Text, existingCourses))
            {
                isValid = false;
                CourseErrorProvider.SetError(CourseDescriptionTextBox, "Ya existe una comision con esa descripcion en el mismo plan con el mismo año de carrera");
            }
            else
            {
                CourseErrorProvider.SetError(CourseDescriptionTextBox, string.Empty);
            }

            if (CourseSectionYearTextBox.Text == null)
            {
                isValid = false;
                CourseErrorProvider.SetError(CourseSectionYearTextBox, "El año de la carrera es requerido");
            }
            else
            {
                CourseErrorProvider.SetError(CourseSectionYearTextBox, string.Empty);
            }

            // Validar ID Plan
            if (IDPlanCourseComboBox.SelectedValue == null)
            {
                isValid = false;
                CourseErrorProvider.SetError(IDPlanCourseComboBox, "El ID del plan es requerido");
            }
            else
            {
                CourseErrorProvider.SetError(IDPlanCourseComboBox, string.Empty);
            }


            return isValid;
        }

        private void IDSectionCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDSectionCourseComboBox.SelectedValue != null)
            {
                var specialty = (SectionDTO)IDSectionCourseComboBox.SelectedItem;

                // Obtener el ID
                int selectedSectionId = specialty.ID;

                // Filtrar planes por specialty
                var filteredPlans = Plans
                    .Where(p => p.IDSection == selectedSectionId)
                    .ToList();

                IDPlanCourseComboBox.DataSource = filteredPlans;
                IDPlanCourseComboBox.DisplayMember = "Description";
                IDPlanCourseComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                IDPlanCourseComboBox.Enabled = filteredPlans.Count > 0;
            }

        }

    }
}
