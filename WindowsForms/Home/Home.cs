namespace WindowsForms

{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MateriasButton_Click(object sender, EventArgs e)
        {
            SubjectsList materiasLista = new SubjectsList(this);
            materiasLista.Show();
            this.Hide();
        }

        private void PlanesButton_Click(object sender, EventArgs e)
        {
            PlanesList planesLista = new PlanesList(this);
            planesLista.Show();
            this.Hide();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserList usersLista = new UserList(this);
            usersLista.Show();
            this.Hide();
        }

        private void SpecialtiesButton_Click(object sender, EventArgs e)
        {
            SpecialtiesList specialtiesLista = new SpecialtiesList(this);
            specialtiesLista.Show();
            this.Hide(); 
        }
    }
}
