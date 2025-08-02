using DTOs;
using WindowsForms.FormSpecialty;

namespace WindowsForms
{
    public partial class SpecialtiesLista : Form
    {
        private Home home;
        public SpecialtiesLista(Home home)
        {
            InitializeComponent();
            this.home = home;
        }
        private void Specialties_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            SpecialtyDetalle specialtyDetalle = new SpecialtyDetalle();

            int id;

            id = this.SelectedItem().ID;

            Specialty specialty = await SpecialtyApiClient.GetAsync(id);

            specialtyDetalle.EditMode = true;
            specialtyDetalle.Specialty = specialty;

            specialtyDetalle.ShowDialog();

            this.GetAllAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await SpecialtyApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SpecialtyDetalle specialtyDetalle = new SpecialtyDetalle();

            Specialty specialtyNuevo = new Specialty();

            specialtyDetalle.Specialty = specialtyNuevo;

            specialtyDetalle.ShowDialog();

            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            SpecialtyApiClient client = new SpecialtyApiClient();

            this.specialtiesDataGridView.DataSource = null;
            this.specialtiesDataGridView.DataSource = await SpecialtyApiClient.GetAllAsync();

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
        
        private Specialty SelectedItem()
        {
            Specialty specialty;

            specialty = (Specialty)specialtiesDataGridView.SelectedRows[0].DataBoundItem;

            return specialty;
        }
        private void specialtiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void specialtiesHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }
    }
}
