using DTOs;
using ApiClients;
namespace WindowsForms
{
    public partial class PlansList : Form
    {
        private AdminHome home;
        public PlansList(AdminHome home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Plans_Load(object sender, EventArgs e)
        {
            this.GetByCriteriaAndLoad();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            PlanDetail planDetalle = new PlanDetail();

            int id;

            id = this.SelectedItem().ID;

            PlanDTO plan = await PlanApiClient.GetAsync(id);

            planDetalle.EditMode = true;
            planDetalle.Plan = plan;

            planDetalle.ShowDialog();

            this.GetByCriteriaAndLoad();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await PlanApiClient.DeleteAsync(id);

            this.GetByCriteriaAndLoad();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            PlanDetail planDetalle = new PlanDetail();

            PlanDTO planNuevo = new PlanDTO();

            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            this.GetByCriteriaAndLoad();
        }

        private async void GetByCriteriaAndLoad(string searchText = "")
        {
            try
            {
                this.plansDataGridView.DataSource = null;

                IEnumerable<PlanDTO> specialties;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    specialties = await PlanApiClient.GetAllAsync();
                }
                else
                {
                    specialties = await PlanApiClient.GetByCriteriaAsync(searchText);
                }

                this.plansDataGridView.DataSource = specialties;

                if (this.plansDataGridView.Rows.Count > 0)
                {
                    this.plansDataGridView.Rows[0].Selected = true;
                    this.deletePlanButton.Enabled = true;
                    this.updatePlanButton.Enabled = true;

                    this.plansDataGridView.Columns["State"].Visible = false;
                    this.plansDataGridView.Columns["DisplayText"].Visible = false;

                    this.plansDataGridView.Columns["Description"].HeaderText = "Descripcion";
                    this.plansDataGridView.Columns["IDSpecialty"].HeaderText = "IDEspecialidad";
                    this.plansDataGridView.Columns["SpecialtyDescription"].HeaderText = "Especialidad";
                    
                }
                else
                {
                    this.deletePlanButton.Enabled = false;
                    this.updatePlanButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de planes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.deletePlanButton.Enabled = false;
                this.updatePlanButton.Enabled = false;
            }
        }

        private PlanDTO SelectedItem()
        {
            PlanDTO plan;

            plan = (PlanDTO)plansDataGridView.SelectedRows[0].DataBoundItem;

            return plan;
        }

        private void planesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlanesHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }
        private void PlanSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = this.PlanSearchBar.Text.Trim();
            this.GetByCriteriaAndLoad(searchText);
        }
    }
}
