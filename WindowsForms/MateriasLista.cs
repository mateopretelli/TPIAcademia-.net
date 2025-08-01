using DTOs;
namespace WindowsForms
{
    public partial class MateriasLista : Form
    {
        public MateriasLista()
        {
            InitializeComponent();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            int id;

            id = this.SelectedItem().ID;

            Materia materia = await MateriaApiClient.GetAsync(id);

            materiaDetalle.EditMode = true;
            materiaDetalle.Materia = materia;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await MateriaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            MateriaDetalle materiaDetalle = new MateriaDetalle();

            Materia materiaNueva = new Materia();

            materiaDetalle.Materia = materiaNueva;

            materiaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            MateriaApiClient client = new MateriaApiClient();

            this.materiasDataGridView.DataSource = null;
            this.materiasDataGridView.DataSource = await MateriaApiClient.GetAllAsync();

            if (this.materiasDataGridView.Rows.Count > 0)
            {
                this.materiasDataGridView.Rows[0].Selected = true;
                this.deleteButton.Enabled = true;
                this.updateButton.Enabled = true;
            }
            else
            {
                this.deleteButton.Enabled = false;
                this.updateButton.Enabled = false;
            }
        }

        private Materia SelectedItem()
        {
            Materia materia;

            materia = (Materia)materiasDataGridView.SelectedRows[0].DataBoundItem;

            return materia;
        }

        private void materiasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
