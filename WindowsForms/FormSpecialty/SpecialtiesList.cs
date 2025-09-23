using DTOs.Specialty;
using WindowsForms.FormSpecialty;

namespace WindowsForms
{
    public partial class SpecialtiesList : Form
    {
        private Home home;
        public SpecialtiesList(Home home)
        {
            InitializeComponent();
            this.home = home;
        }
        private void Specialties_Load(object sender, EventArgs e)
        {
            this.GetByCriteriaAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            SpecialtyDetail specialtyDetalle = new SpecialtyDetail();

            int id;

            id = this.SelectedItem().ID;

            SpecialtyDTO specialty = await SpecialtyApiClient.GetAsync(id);

            specialtyDetalle.EditMode = true;
            specialtyDetalle.Specialty = specialty;

            specialtyDetalle.ShowDialog();

            this.GetByCriteriaAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await SpecialtyApiClient.DeleteAsync(id);

            this.GetByCriteriaAndLoad();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SpecialtyDetail specialtyDetalle = new SpecialtyDetail();

            SpecialtyDTO specialtyNuevo = new SpecialtyDTO();

            specialtyDetalle.Specialty = specialtyNuevo;

            specialtyDetalle.ShowDialog();

            this.GetByCriteriaAndLoad();
        }
        private async void GetByCriteriaAndLoad(string searchText= "")
        {
            try
            {
                this.specialtiesDataGridView.DataSource = null;

                IEnumerable<SpecialtyDTO> specialties;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    specialties = await SpecialtyApiClient.GetAllAsync();
                }
                else
                {
                    specialties = await SpecialtyApiClient.GetByCriteriaAsync(searchText);
                }

                this.specialtiesDataGridView.DataSource = specialties;

                if (this.specialtiesDataGridView.Rows.Count > 0)
                {
                    this.specialtiesDataGridView.Rows[0].Selected = true;
                    this.deleteSpecialtyButton.Enabled = true;
                    this.updateSpecialtyButton.Enabled = true;
                }
                else
                {
                    this.deleteSpecialtyButton.Enabled = false;
                    this.updateSpecialtyButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.deleteSpecialtyButton.Enabled = false;
                this.updateSpecialtyButton.Enabled = false;
            }
        }

        private SpecialtyDTO SelectedItem()
        {
            SpecialtyDTO specialty;

            specialty = (SpecialtyDTO)specialtiesDataGridView.SelectedRows[0].DataBoundItem;

            return specialty;
        }
        private void specialtiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void specialtiesHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void SpecialtySearchButton_Click(object sender, EventArgs e)
        {
            string searchText = this.SpecialtySearchBar.Text.Trim();
            this.GetByCriteriaAndLoad(searchText);
        }
    }
}
