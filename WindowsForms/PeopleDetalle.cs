using DTOs;

namespace WindowsForms
{
    public partial class PeopleDetalle : Form
    {
        
        private Person person;
        public PeopleDetalle()
        {
            InitializeComponent();
        }

        public Person Person
        {
            get { return person; }
            set
            {
                person = value;
                this.SetPeople();
            }
        }

        public bool EditMode { get; set; } = false;

        private async void acceptPersonButton_Click(object sender, EventArgs e)
        {
            PeopleApiClient client = new PeopleApiClient();
            IEnumerable<Person> peopleExistentes = await PeopleApiClient.GetAllAsync();
            if (this.ValidatePerson(peopleExistentes))
            {
                this.Person.Name = personNameTextBox.Text;
                this.Person.LastName = personLastNameTextBox.Text;
                this.Person.Email = personEmailTextBox.Text;
                this.Person.PhoneNumber = personPhoneNumberTextBox.Text;
                if (this.EditMode)
                {
                    await PeopleApiClient.UpdateAsync(this.Person);
                }
                else
                {
                    await PeopleApiClient.AddAsync(this.Person);
                }
                this.Close();
            }
        }

        private void SetPeople()
        {
            if (this.Person != null)
            {
                personNameTextBox.Text = this.Person.Name;
                personLastNameTextBox.Text = this.Person.LastName;
                personEmailTextBox.Text = this.Person.Email;
                personPhoneNumberTextBox.Text = this.Person.PhoneNumber;
            }
        }

        private bool ValidatePerson(IEnumerable<Person> peopleExistentes)
        {
            if (string.IsNullOrWhiteSpace(personNameTextBox.Text) || string.IsNullOrWhiteSpace(personLastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(personEmailTextBox.Text) || string.IsNullOrWhiteSpace(personPhoneNumberTextBox.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }
            if (peopleExistentes.Any(p => p.Email == personEmailTextBox.Text && p.ID != this.Person.ID))
            {
                MessageBox.Show("A person with this email already exists.");
                return false;
            }
            return true;

        }

        private void cancelPersonButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PeopleDetalle_Load(object sender, EventArgs e)
        {
            if (this.EditMode)
            {
                this.Text = "Edit Person";
            }
            else
            {
                this.Text = "Add Person";
            }
        }
    }
