using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.FormPlans;
using WindowsForms.FormSpecialty;
using WindowsForms.FormSubject;

namespace WindowsForms.FormSection
{
    public partial class SectionDetail : Form
    {
        private SectionDTO section;

        private IEnumerable<SpecialtyDTO> Specialties { get; set; }

        private IEnumerable<PlanDTO> Plans { get; set; }

        public PlanDTO Plan { get; set; }

        public SectionDTO Section
        {
            get { return section; }
            set
            {
                section = value;
                this.SetSection();
            }
        }

        public bool EditMode { get; set; } = false;

        public SectionDetail()
        {
            InitializeComponent();
        }

        private async void acceptSectionButton_Click(object sender, EventArgs e)
        {
            IEnumerable<SectionDTO> existingSections = await SectionApiClient.GetAllAsync();

            if (this.ValidateSection(existingSections))
            {
                this.Section.SpecialtyYear = int.Parse(SectionSpecialtyYearTextBox.Text);
                this.Section.IDPlan = Convert.ToInt32(IDPlanSectionComboBox.SelectedValue);
                this.Section.Description = SectionDescriptionTextBox.Text;

                try
                {
                    if (this.EditMode)
                    {
                        await SectionApiClient.UpdateAsync(this.Section);
                    }
                    else
                    {
                        await SectionApiClient.AddAsync(this.Section);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar Comision: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.Close();
            }
        }

        private void cancelSectionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidDescription(string descripcion, IEnumerable<SectionDTO> sections)
        {
            if (descripcion == this.Section.Description)
            {
                return false; // Si la descripción no cambió, no es necesario validar
            }
            else
            {
                var foundedSection = from SectionDTO s in sections
                                     where s.Description == descripcion &&
                                     s.IDPlan == this.Section.IDPlan
                                     && s.SpecialtyYear == this.Section.SpecialtyYear
                                     && s.State == "Active"
                                     select s;

                return foundedSection.Any();
            }

        }

        private async void SetSection()
        {
            Plans = await PlanApiClient.GetAllAsync();
            Specialties = await SpecialtyApiClient.GetAllAsync();

            SectionIDTextBox.Text = this.Section.ID.ToString();
            SectionDescriptionTextBox.Text = this.Section.Description;
            SectionSpecialtyYearTextBox.Text = this.Section.SpecialtyYear.ToString();
            SectionStateTextBox.Text = this.Section.State;

            IDSpecialtySectionComboBox.SelectedValue = this.Plan?.SpecialtyDescription;

            IDSpecialtySectionComboBox.DataSource = Specialties;
            IDSpecialtySectionComboBox.DisplayMember = "Description";
            IDSpecialtySectionComboBox.ValueMember = "ID";
        }

        private bool ValidateSection(IEnumerable<SectionDTO> existingSections)
        {
            bool isValid = true;

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(this.SectionDescriptionTextBox.Text))
            {
                isValid = false;
                SectionErrorProvider.SetError(SectionDescriptionTextBox, "La descripción es requerida");
            }
            else if (ValidDescription(this.SectionDescriptionTextBox.Text, existingSections))
            {
                isValid = false;
                SectionErrorProvider.SetError(SectionDescriptionTextBox, "Ya existe una comision con esa descripcion en el mismo plan con el mismo año de carrera");
            }
            else
            {
                SectionErrorProvider.SetError(SectionDescriptionTextBox, string.Empty);
            }

            if (SectionSpecialtyYearTextBox.Text == null)
            {
                isValid = false;
                SectionErrorProvider.SetError(SectionSpecialtyYearTextBox, "El año de la carrera es requerido");
            }
            else
            {
                SectionErrorProvider.SetError(SectionSpecialtyYearTextBox, string.Empty);
            }

            // Validar ID Plan
            if (IDPlanSectionComboBox.SelectedValue == null)
            {
                isValid = false;
                SectionErrorProvider.SetError(IDPlanSectionComboBox, "El ID del plan es requerido");
            }
            else
            {
                SectionErrorProvider.SetError(IDPlanSectionComboBox, string.Empty);
            }


            return isValid;
        }
        
        private void IDSpecialtySectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDSpecialtySectionComboBox.SelectedValue != null)
            {
                var specialty = (SpecialtyDTO)IDSpecialtySectionComboBox.SelectedItem;

                // Obtener el ID
                int selectedSpecialtyId = specialty.ID;

                // Filtrar planes por specialty
                var filteredPlans = Plans
                    .Where(p => p.IDSpecialty == selectedSpecialtyId)
                    .ToList();

                IDPlanSectionComboBox.DataSource = filteredPlans;
                IDPlanSectionComboBox.DisplayMember = "Description";
                IDPlanSectionComboBox.ValueMember = "ID";

                // Habilitar si hay resultados
                IDPlanSectionComboBox.Enabled = filteredPlans.Count > 0;
            }

        }

    }
}
