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
            MateriasLista materiasLista = new MateriasLista(this);
            materiasLista.Show();
            this.Hide();
        }

        private void PlanesButton_Click(object sender, EventArgs e)
        {
            PlanesLista planesLista = new PlanesLista(this);
            planesLista.Show();
            this.Hide();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserLista usersLista = new UserLista(this);
            usersLista.Show();
            this.Hide();
        }

        private void SpecialtiesButton_Click(object sender, EventArgs e)
        {
            SpecialtiesLista specialtiesLista = new SpecialtiesLista(this);
            specialtiesLista.Show();
            this.Hide(); 
        }
    }
}
