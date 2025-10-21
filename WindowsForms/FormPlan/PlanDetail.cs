using DTOs;
using System.Data;
using ApiClients;


namespace WindowsForms
{
    public partial class PlanDetail : Form
    {

        private PlanDTO plan;
        private IEnumerable<SpecialtyDTO> Specialties {get; set; }
        public PlanDTO Plan
        {
            get { return plan; }
            set
            {
                plan = value;
                this.SetPlan();
            }
        }

        public bool EditMode { get; set; } = false;

        public PlanDetail()
        {
            InitializeComponent();
        }

        private async void acceptPlanButton_Click(object sender, EventArgs e)
        {
            try
            {
                PlanApiClient client = new PlanApiClient();
                IEnumerable<PlanDTO> Existantplans = await PlanApiClient.GetAllAsync();
                if (this.ValidatePlan(Existantplans))
                {
                    this.Plan.Description = PlanDescriptionTextBox.Text.TrimEnd().TrimStart();
                    this.Plan.IDSpecialty = Convert.ToInt32(SpecialtyIDComboBox.SelectedValue);
                    this.Plan.State = PlanStateTextBox.Text;
                    if (this.EditMode)
                    {
                        await PlanApiClient.UpdateAsync(this.Plan);
                    }
                    else
                    {
                        await PlanApiClient.AddAsync(this.Plan);
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el plan: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelPlanButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void SetPlan()
        {
            
            Specialties = await SpecialtyApiClient.GetAllAsync();

            PlanIDTextBox.Text = this.Plan.ID.ToString();
            PlanStateTextBox.Text = this.Plan.State;
            PlanDescriptionTextBox.Text = this.Plan.Description;

            SpecialtyIDComboBox.DataSource = Specialties;
            SpecialtyIDComboBox.DisplayMember = "Description";
            SpecialtyIDComboBox.ValueMember = "ID";

            SpecialtyIDComboBox.SelectedValue = this.Plan.IDSpecialty;
        }

        private bool ValidatePlan(IEnumerable<PlanDTO> Existantplans)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(PlanDescriptionTextBox.Text))
            {
                errorProvider1.SetError(PlanDescriptionTextBox, "La descripción es requerida");
                isValid = false;

            }
            else if (ValidateDescription(PlanDescriptionTextBox.Text, Existantplans))
            {
                errorProvider1.SetError(PlanDescriptionTextBox, "La descripción ya pertenece a otro plan de la especialidad");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(PlanDescriptionTextBox, string.Empty);
            }

            if (SpecialtyIDComboBox.SelectedValue == null ||
            Convert.ToInt32(SpecialtyIDComboBox.SelectedValue) <= 0)
            {
                errorProvider1.SetError(SpecialtyIDComboBox, "Debe seleccionar una especialidad");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(SpecialtyIDComboBox, string.Empty);
            }
            return isValid;
        }

        // ID y State no se validan porque están disabled ya que se generan por sistema.

        private bool ValidateDescription(string description, IEnumerable<PlanDTO> Existantplans)
        {
            if (description.TrimEnd() == this.Plan.Description)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }
            else
            {
                var findedPlan = from PlanDTO p in Existantplans
                                     where p.Description == description &&
                                     p.State == "Active"
                                     select p;

                return findedPlan.Any();
            }
        }


    }
}
