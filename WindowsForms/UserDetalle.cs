using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;

namespace WindowsForms
{
    public partial class UserDetalle : Form
    {

        private User user;

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                this.SetUser();
            }
        }

        public bool EditMode { get; set; } = false;

        public UserDetalle()
        {
            InitializeComponent();
        }

        private async void AcceptUserButton_Click(object sender, EventArgs e)
        {
            UserApiClient client = new UserApiClient();
            IEnumerable<User> existingUsers = await UserApiClient.GetAllAsync();

            if (this.ValidateUser(existingUsers))
            {
                this.User.Name = NameTextBox.Text;
                this.User.LastName = LastNameTextBox.Text;
                this.User.Email = EmailTextBox.Text;
                this.User.Address = AddressTextBox.Text;
                this.User.Phone = PhoneTextBox.Text;
                //this.User.Legajo = int.TryParse(LegajoTextBox.Text, out int legajo) ? legajo : 0;
                this.User.BirthDate = DateTime.TryParse(BirthDateTextBox.Text, out DateTime birthDate) ? birthDate : DateTime.MinValue;
                this.User.IDPlan = int.TryParse(IDPlanTextBox.Text, out int idPlan) ? idPlan : 0;
                this.User.Username = UsernameTextBox.Text;
                this.User.Password = PasswordTextBox.Text;
                //this.User.State = StateTextBox.Text;

                if (this.EditMode)
                {
                    await UserApiClient.UpdateAsync(this.User);
                }
                else
                {
                    await UserApiClient.AddAsync(this.User);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUser()
        {
            if (this.User != null)
            {
                NameTextBox.Text = this.User.Name;
                LastNameTextBox.Text = this.User.LastName;
                EmailTextBox.Text = this.User.Email;
                AddressTextBox.Text = this.User.Address;
                PhoneTextBox.Text = this.User.Phone;
                //LegajoTextBox.Text = this.User.Legajo.ToString();
                BirthDateTextBox.Text = this.User.BirthDate.ToString("yyyy-MM-dd");
                IDPlanTextBox.Text = this.User.IDPlan.ToString();
                UsernameTextBox.Text = this.User.Username;
                PasswordTextBox.Text = this.User.Password;
                ConfirmPasswordTextBox.Text = this.User.Password;
               // StateTextBox.Text = this.User.State;
            }
        }

        private bool ValidateUser(IEnumerable<User> existingUsers)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(BirthDateTextBox.Text) ||
                string.IsNullOrWhiteSpace(IDPlanTextBox.Text) ||
                string.IsNullOrWhiteSpace(UsernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (existingUsers.Any(u => u.Username == UsernameTextBox.Text && u.ID != this.User?.ID))
            {
                MessageBox.Show("Username already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }




    }
}
