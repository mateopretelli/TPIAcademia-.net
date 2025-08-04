using DTOs;
using WindowsForms.FormPlans;
namespace WindowsForms
{
    public partial class PlanesLista : Form
    {
        private Home home;
        public PlanesLista(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            int id;

            id = this.SelectedItem().ID;

            Plan plan = await PlanApiClient.GetAsync(id);

            planDetalle.EditMode = true;
            planDetalle.Plan = plan;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await PlanApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            PlanDetalle planDetalle = new PlanDetalle();

            Plan planNuevo = new Plan();

            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PlanApiClient client = new PlanApiClient();

            this.planesDataGridView.DataSource = null;
            this.planesDataGridView.DataSource = await PlanApiClient.GetAllAsync();

            if (this.planesDataGridView.Rows.Count > 0)
            {
                this.planesDataGridView.Rows[0].Selected = true;
                this.deletePlanButton.Enabled = true;
                this.updatePlanButton.Enabled = true;
            }
            else
            {
                this.deletePlanButton.Enabled = false;
                this.updatePlanButton.Enabled = false;
            }
        }

        private Plan SelectedItem()
        {
            Plan plan;

            plan = (Plan)planesDataGridView.SelectedRows[0].DataBoundItem;

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
    }
}
