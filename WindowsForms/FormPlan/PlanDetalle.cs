using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using WindowsForms.FormPlan;

namespace WindowsForms
{
    public partial class PlanDetalle : Form
    {

        private Plan plan;
        public Plan Plan
        {
            get { return plan; }
            set
            {
                plan = value;
                this.SetPlan();
            }
        }

        public bool EditMode { get; set; } = false;

        public PlanDetalle()
        {
            InitializeComponent();
        }

        private async void acceptPlanButton_Click(object sender, EventArgs e)
        {
            PlanApiClient client = new PlanApiClient();
            IEnumerable<Plan> planesExistentes = await PlanApiClient.GetAllAsync();
            if (this.ValidatePlan(planesExistentes))
            {
                this.Plan.Descripcion = PlanDescriptionTextBox.Text;
                this.Plan.IDEspecialidad = int.Parse(PlanIDSpecialityTextBox.Text);
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

        private void cancelPlanButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetPlan()
        {
            PlanIDTextBox.Text = this.Plan.ID.ToString();
            PlanStateTextBox.Text = this.Plan.State;
            PlanDescriptionTextBox.Text = this.Plan.Descripcion;
            PlanIDSpecialityTextBox.Text = this.Plan.IDEspecialidad.ToString();
        }

        private bool ValidatePlan(IEnumerable<Plan> planesExistentes)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(PlanDescriptionTextBox.Text))
            {
                errorProvider1.SetError(PlanDescriptionTextBox, "La descripción es requerida");
                isValid = false;

            }
            else if (ValidateDescription(PlanDescriptionTextBox.Text, PlanIDSpecialityTextBox.Text, planesExistentes))
            {
                errorProvider1.SetError(PlanDescriptionTextBox, "La descripción ya pertenece a otro plan de la especialidad");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(PlanDescriptionTextBox, string.Empty);
            }
            // Validar IDEspecialidad
            if (string.IsNullOrWhiteSpace(PlanIDSpecialityTextBox.Text))
            {
                errorProvider1.SetError(PlanIDSpecialityTextBox, "El ID de especialidad es requerido.");
            }
            else if (!int.TryParse(PlanIDSpecialityTextBox.Text, out int idEspecialidad) || idEspecialidad <= 0)
            {
                errorProvider1.SetError(PlanIDSpecialityTextBox, "El ID de especialidad debe ser un numero positivo.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(PlanIDSpecialityTextBox, string.Empty);
            }

            return isValid;
        }

        // ID y State no se validan porque están disabled ya que se generan por sistema.

        private bool ValidateDescription(string descripcion, string idEsp, IEnumerable<Plan> planesExistenes)
        {
            if (descripcion == this.Plan.Descripcion)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }
            else
            {
                var planEncontrado = from Plan p in planesExistenes
                                     where p.Descripcion == descripcion &&
                                     p.State == "Active" &&
                                     p.IDEspecialidad.ToString() == idEsp
                                     select p;

                return planEncontrado.Any();
            }
        }

    }
}
