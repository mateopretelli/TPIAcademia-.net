using DTOs;
using ApiClients;

namespace WindowsForms
{
    public partial class UserList : Form
    {
        private AdminHome home;
        public UserList(AdminHome home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {

            UserDetail userDetalle = new UserDetail();

            int id;

            id = this.SelectedItem().ID;

            UserDTO user = await UserApiClient.GetAsync(id);

            userDetalle.EditMode = true;
            userDetalle.User = user;

            userDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().ID;
            await UserApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            UserDetail userDetalle = new UserDetail();

            UserDTO userNuevo = new UserDTO();

            userDetalle.User = userNuevo;

            userDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            UserApiClient client = new UserApiClient();

            this.userDataGridView.DataSource = null;
            this.userDataGridView.DataSource = await UserApiClient.GetAllAsync();

            if (this.userDataGridView.Columns.Count > 0)
            {
                this.userDataGridView.Columns["Password"].Visible = false;
                this.userDataGridView.Columns["State"].Visible = false;
                this.userDataGridView.Columns["Salt"].Visible = false;
                // Agrega más columnas que quieras ocultar

                // También puedes cambiar el orden
                this.userDataGridView.Columns["ID"].DisplayIndex = 0;
                this.userDataGridView.Columns["Username"].DisplayIndex = 1;
                this.userDataGridView.Columns["Name"].DisplayIndex = 2;
                this.userDataGridView.Columns["LastName"].DisplayIndex = 3;
                this.userDataGridView.Columns["Email"].DisplayIndex = 4;
                this.userDataGridView.Columns["Type"].DisplayIndex = 5;
                this.userDataGridView.Columns["Legajo"].DisplayIndex = 7;
                this.userDataGridView.Columns["BirthDate"].DisplayIndex = 6;
                this.userDataGridView.Columns["Address"].DisplayIndex = 8;
                this.userDataGridView.Columns["Phone"].DisplayIndex = 9;
                this.userDataGridView.Columns["IDPlan"].DisplayIndex = 10;


                // Cambiar nombres de encabezados
                this.userDataGridView.Columns["Name"].HeaderText = "Nombre";
                this.userDataGridView.Columns["LastName"].HeaderText = "Apellido";
                this.userDataGridView.Columns["Username"].HeaderText = "Usuario";
                this.userDataGridView.Columns["Type"].HeaderText = "Tipo";
                this.userDataGridView.Columns["Legajo"].HeaderText = "Legajo";
                this.userDataGridView.Columns["BirthDate"].HeaderText = "FechaNac";
                this.userDataGridView.Columns["Phone"].HeaderText = "Teléfono";
                this.userDataGridView.Columns["Address"].HeaderText = "Dirección";

            }

            if (this.userDataGridView.Rows.Count > 0)
            {
                this.userDataGridView.Rows[0].Selected = true;
                this.deleteUserButton.Enabled = true;
                this.updateUserButton.Enabled = true;
            }
            else
            {
                this.deleteUserButton.Enabled = false;
                this.updateUserButton.Enabled = false;
            }
        }

        private UserDTO SelectedItem()
        {
            UserDTO user;

            user = (UserDTO)userDataGridView.SelectedRows[0].DataBoundItem;


            return user;
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }
    }
}
