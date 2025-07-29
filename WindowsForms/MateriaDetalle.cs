using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;

namespace WindowsForms
{
    public partial class MateriaDetalle : Form
    {
        private Materia materia;

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }

        public bool EditMode { get; set; } = false;

        public MateriaDetalle()
        {
            InitializeComponent();
        }

        private async void acceptButton_Click(object sender, EventArgs e)
        {
            MateriaApiClient client = new MateriaApiClient();
            IEnumerable<Materia> materiasExistentes = await MateriaApiClient.GetAllAsync();

            if (this.ValidateMateria(materiasExistentes))
            {
                this.Materia.Descripcion = descriptionTextBox.Text;
                this.Materia.HSSemanales = int.Parse(weeklyHoursTextBox.Text);
                this.Materia.HSTotales = int.Parse(totalHoursTextBox.Text);
                this.Materia.IDPlan = int.Parse(idPlanTextBox.Text);

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await MateriaApiClient.UpdateAsync(this.Materia);
                }
                else
                {
                    await MateriaApiClient.AddAsync(this.Materia);
                }

                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetMateria()
        {
            this.idTextBox.Text = this.Materia.ID.ToString();
            this.descriptionTextBox.Text = this.Materia.Descripcion;
            this.weeklyHoursTextBox.Text = this.Materia.HSSemanales.ToString();
            this.totalHoursTextBox.Text = this.Materia.HSTotales.ToString();
            this.stateTextBox.Text = this.Materia.State;
            this.idPlanTextBox.Text = this.Materia.IDPlan.ToString();
        }

        private bool ValidateMateria(IEnumerable<Materia> materiasExistentes)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(this.descriptionTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(descriptionTextBox, "La descripción es requerida");
            }
            else if (ValidDescription(this.descriptionTextBox.Text, materiasExistentes))
            {
                isValid = false;
                errorProvider.SetError(descriptionTextBox, "Ya existe una materia con esa descripcion");
            }
            else
            {
                errorProvider.SetError(descriptionTextBox, string.Empty);
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
            if (string.IsNullOrWhiteSpace(this.idPlanTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(idPlanTextBox, "El ID del plan es requerido");
            }
            else if (!int.TryParse(this.idPlanTextBox.Text, out int idPlan) || idPlan < 1)
            {
                isValid = false;
                errorProvider.SetError(idPlanTextBox, "Ingrese un ID de plan válido mayor a 0");
            }
            else
            {
                errorProvider.SetError(idPlanTextBox, string.Empty);
            }

            return isValid;
        }

        private bool ValidDescription(string descripcion, IEnumerable<Materia> materias)
        {
            if(descripcion == this.Materia.Descripcion)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }else 
            {
                var materiaEncontrada = from Materia m in materias
                                        where m.Descripcion == descripcion &&
                                        m.State == "Active"
                                        select m;

                return materiaEncontrada.Any();
            }
                
        }

    }
}
