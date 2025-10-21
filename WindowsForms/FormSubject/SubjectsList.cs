using DTOs;
using ApiClients;

namespace WindowsForms
{
    public partial class SubjectsList : Form
    {
        private AdminHome home;
        public SubjectsList(AdminHome home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void updateMateriaButton_Click(object sender, EventArgs e)
        {
            SubjectDetail materiaDetalle = new SubjectDetail();

            int id;

            id = this.SelectedItem().ID;

            SubjectDTO subject = await SubjectApiClient.GetAsync(id);

            materiaDetalle.EditMode = true;
            materiaDetalle.Subject = subject;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteMateriaButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await SubjectApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }
        private void addMateriaButton_Click(object sender, EventArgs e)
        {
            SubjectDetail materiaDetalle = new SubjectDetail();

            SubjectDTO newSubject = new SubjectDTO();

            materiaDetalle.Subject = newSubject;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            SubjectApiClient client = new SubjectApiClient();

            this.materiasDataGridView.DataSource = null;
            this.materiasDataGridView.DataSource = await SubjectApiClient.GetAllAsync();

            if (this.materiasDataGridView.Rows.Count > 0)
            {
                this.materiasDataGridView.Rows[0].Selected = true;
                this.deleteMateriaButton.Enabled = true;
                this.updateMateriaButton.Enabled = true;

                this.materiasDataGridView.Columns["State"].Visible = false;
                this.materiasDataGridView.Columns["Plan"].Visible = false;

                this.materiasDataGridView.Columns["Description"].HeaderText = "Descripcion";
                this.materiasDataGridView.Columns["WeeklyHS"].HeaderText = "HSSemanales";
                this.materiasDataGridView.Columns["TotalHS"].HeaderText = "HSTotales";
                this.materiasDataGridView.Columns["PlanDescription"].HeaderText = "DescripcionPlan";
            }
            else
            {
                this.deleteMateriaButton.Enabled = false;
                this.updateMateriaButton.Enabled = false;
            }
        }

        private SubjectDTO SelectedItem()
        {
            SubjectDTO subject;

            subject = (SubjectDTO)materiasDataGridView.SelectedRows[0].DataBoundItem;

            return subject;
        }

        private void materiasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MateriasHomeButton_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
