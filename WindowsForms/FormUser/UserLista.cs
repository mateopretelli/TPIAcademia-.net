using DTOs;
using WindowsForms.FormUser;
namespace WindowsForms
{
    public partial class UserLista : Form
    {
        private Home home;
        public UserLista(Home home)
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
            UserDetalle userDetalle = new UserDetalle();

            int id;

            id = this.SelectedItem().ID;

            User user = await UserApiClient.GetAsync(id);

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
            UserDetalle userDetalle = new UserDetalle();

            User userNuevo = new User();

            userDetalle.User = userNuevo;

            userDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            UserApiClient client = new UserApiClient();

            this.userDataGridView.DataSource = null;
            this.userDataGridView.DataSource = await UserApiClient.GetAllAsync();


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

        private User SelectedItem()
        {
            User user;

            user = (User)userDataGridView.SelectedRows[0].DataBoundItem;

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
