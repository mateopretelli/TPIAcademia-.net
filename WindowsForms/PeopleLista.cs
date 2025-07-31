using DTOs;

namespace WindowsForms
{
    public partial class PeopleLista : Form
    {
        private Home home;
        public PeopleLista(Home home)
        {
            InitializeComponent();
            this.home = home;
        }
        private void PeopleLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void updatePersonButton_Click(object sender, EventArgs e)
        {
            PeopleDetalle peopledetalle = new PeopleDetalle();
            int id;
            id = this.SelectedItem().ID;
            Person person = await PeopleApiClient.GetAsync(id);
            peopledetalle.EditMode = true;
            peopledetalle.Person = person;
            peopledetalle.ShowDialog();
            this.GetAllAndLoad();
        }

        private async void deletePersonButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.SelectedItem().ID;
            await PeopleApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PeopleDetalle peopledetalle = new PeopleDetalle();
            Person newPerson = new Person();
            peopledetalle.Person = newPerson;
            peopledetalle.ShowDialog();
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PeopleApiClient client = new PeopleApiClient();
            var people = await client.GetAllAsync();
            this.peopleDataGridView.DataSource = people;
        }

        private Person SelectedItem()
        {
            if (this.peopleDataGridView.SelectedRows.Count > 0)
            {
                return this.peopleDataGridView.SelectedRows[0].DataBoundItem as Person;
            }
            else
            {
                return null;
            }
        }
}
