using DTOs.Plan;
using DTOs.Specialty;
using DTOs.Subject;
using System.Data;
using WindowsForms.FormSpecialty;
using WindowsForms.FormPlans;
using WindowsForms.FormSubject;
using System.Security.AccessControl;
using System.Diagnostics;

namespace WindowsForms
{
    public partial class MateriaDetalle : Form
    {
        private SubjectDTO subject;

        private PlanDTO plan;

        private SpecialtyDTO specialty;

        private IEnumerable<SpecialtyDTO> Specialties { get; set; }

        private IEnumerable<PlanDTO> Plans { get; set; }

        public PlanDTO Plan { get; set; }

        private SpecialtyDTO Specialty { get; set; }
        public SubjectDTO Subject
        {
            get { return subject; }
            set
            {
                subject = value;
                this.SetSubject();
            }
        }

        public bool EditMode { get; set; } = false;

        public MateriaDetalle()
        {
            InitializeComponent();
        }

        private async void acceptSubjectButton_Click(object sender, EventArgs e)
        {
            IEnumerable<SubjectDTO> materiasExistentes = await SubjectApiClient.GetAllAsync();

            if (this.ValidateMateria(materiasExistentes))
            {
                this.Subject.WeeklyHS = int.Parse(weeklyHoursTextBox.Text);
                this.Subject.TotalHS = int.Parse(totalHoursTextBox.Text);
                this.Subject.IDPlan = Convert.ToInt32(IDPlanComboBox.SelectedValue);
                this.Subject.Description = MateriaDescriptionTextBox.Text;

                if (this.EditMode)
                {
                    await SubjectApiClient.UpdateAsync(this.Subject);
                }
                else
                {
                    await SubjectApiClient.AddAsync(this.Subject);
                }

                this.Close();
            }
        }
        private void cancelSubjectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SetSubject()
        {
            Plans = await PlanApiClient.GetAllAsync();
            Specialties = await SpecialtyApiClient.GetAllAsync();

            MateriaIDTextBox.Text = this.Subject.ID.ToString();
            MateriaDescriptionTextBox.Text = this.Subject.Description;
            weeklyHoursTextBox.Text = this.Subject.WeeklyHS.ToString();
            totalHoursTextBox.Text = this.Subject.TotalHS.ToString();
            MateriaStateTextBox.Text = this.Subject.State;

            IDSpecialtyComboBox.SelectedValue = this.Plan?.SpecialtyDescription;
            Debug.WriteLine(this.Plan?.SpecialtyDescription);

            IDSpecialtyComboBox.DataSource = Specialties;
            IDSpecialtyComboBox.DisplayMember = "Description";
            IDSpecialtyComboBox.ValueMember = "ID";

        }

        private bool ValidateMateria(IEnumerable<SubjectDTO> materiasExistentes)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(this.MateriaDescriptionTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(MateriaDescriptionTextBox, "La descripción es requerida");
            }
            else if (ValidDescription(this.MateriaDescriptionTextBox.Text, materiasExistentes))
            {
                isValid = false;
                errorProvider.SetError(MateriaDescriptionTextBox, "Ya existe una materia con esa descripcion");
            }
            else
            {
                errorProvider.SetError(MateriaDescriptionTextBox, string.Empty);
            }

            // Validar Horas Semanales
            if (string.IsNullOrWhiteSpace(this.weeklyHoursTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(weeklyHoursTextBox, "Las horas semanales son requeridas");
            }
            else if (!int.TryParse(this.weeklyHoursTextBox.Text, out int hsSem) || hsSem < 1)
            {
                isValid = false;
                errorProvider.SetError(weeklyHoursTextBox, "Ingrese un número válido mayor a 0");
            }
            else
            {
                errorProvider.SetError(weeklyHoursTextBox, string.Empty);
            }

            // Validar Horas Totales
            if (string.IsNullOrWhiteSpace(this.totalHoursTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(totalHoursTextBox, "Las horas totales son requeridas");
            }
            else if (!int.TryParse(this.totalHoursTextBox.Text, out int hsTot) || hsTot < 1)
            {
                isValid = false;
                errorProvider.SetError(totalHoursTextBox, "Ingrese un número válido mayor a 0");
            }
            else
            {
                errorProvider.SetError(totalHoursTextBox, string.Empty);
            }

            // Validar ID Plan
            if (IDPlanComboBox.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(IDPlanComboBox, "El ID del plan es requerido");
            }
            else
            {
                errorProvider.SetError(IDPlanComboBox, string.Empty);
            }

            return isValid;
        }

        private bool ValidDescription(string descripcion, IEnumerable<SubjectDTO> materias)
        {
            if (descripcion == this.Subject.Description)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }
            else
            {
                var materiaEncontrada = from SubjectDTO m in materias
                                        where m.Description == descripcion &&
                                        m.State == "Active"
                                        select m;

                return materiaEncontrada.Any();
            }

        }
        private void IDSpecialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDSpecialtyComboBox.SelectedValue != null)
            {
                var specialty = (SpecialtyDTO)IDSpecialtyComboBox.SelectedItem;

                // Obtener el ID
                int selectedSpecialtyId = specialty.ID;

                // Filtrar planes por specialty
                var filteredPlans = Plans
                    .Where(p => p.IDSpecialty == selectedSpecialtyId)
                    .ToList();

                IDPlanComboBox.DataSource = filteredPlans;
                IDPlanComboBox.DisplayMember = "Description";
                IDPlanComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                IDPlanComboBox.Enabled = filteredPlans.Count > 0;
            }
        }
    }
}
