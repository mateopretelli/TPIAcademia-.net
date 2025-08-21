using DTOs;
using System.Data;
using WindowsForms.FormPlans;
using WindowsForms.FormSpecialty;

namespace WindowsForms
{
    public partial class SpecialtyDetalle : Form
    {
        private SpecialtyDTO specialty;
        public SpecialtyDTO Specialty
        {
            get { return specialty; }
            set
            {
                specialty = value;
                this.SetSpecialty();
            }
        }
        public bool EditMode { get; set; } = false;

        public SpecialtyDetalle()
        {
            InitializeComponent();
        }
        private async void acceptSpecialtyButton_Click(object sender, EventArgs e)
        {
            SpecialtyApiClient client = new SpecialtyApiClient();
            IEnumerable<SpecialtyDTO> ExistantSpecialties = await SpecialtyApiClient.GetAllAsync();
            if (this.ValidateSpecialty(ExistantSpecialties))
            {
                this.Specialty.Descripcion = SpecialtyDescriptionTextBox.Text.TrimEnd().TrimStart();
                this.Specialty.State = SpecialtyStateTextBox.Text;
                if (this.EditMode)
                {
                    await SpecialtyApiClient.UpdateAsync(this.Specialty);
                }
                else
                {
                    await SpecialtyApiClient.AddAsync(this.Specialty);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelSpecialtyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetSpecialty()
        {
            SpecialtyIDTextBox.Text = this.Specialty.ID.ToString();
            SpecialtyStateTextBox.Text = this.Specialty.State;
            SpecialtyDescriptionTextBox.Text = this.Specialty.Descripcion;
        }
        private bool ValidateSpecialty(IEnumerable<SpecialtyDTO> ExistantSpecialties)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(SpecialtyDescriptionTextBox.Text))
            {
                errorProvider1.SetError(SpecialtyDescriptionTextBox, "La descripción es requerida");
                isValid = false;

            }
            else if (ValidateDescription(SpecialtyDescriptionTextBox.Text, ExistantSpecialties))
            {
                errorProvider1.SetError(SpecialtyDescriptionTextBox, "La descripción ya pertenece a otra Especialidad");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(SpecialtyDescriptionTextBox, string.Empty);
            }

            return isValid;
        }

        // ID y State no se validan porque están disabled ya que se generan por sistema.

        private bool ValidateDescription(string descripcion, IEnumerable<SpecialtyDTO> ExistantSpecialties)
        {
            if (descripcion.TrimEnd() == this.Specialty.Descripcion)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }
            else
            {
                var findedSpecialty = from SpecialtyDTO p in ExistantSpecialties
                                      where p.Descripcion.TrimEnd().TrimStart() == descripcion.TrimEnd().TrimStart() &&
                                      p.State == "Active"
                                      select p;

                return findedSpecialty.Any();
            }
        }

    }
}
