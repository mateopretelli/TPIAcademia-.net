using DTOs.Plan;
using DTOs.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.FormPlans;
using WindowsForms.FormSubject;
using WindowsForms.FormUser;

namespace WindowsForms
{

    public partial class UserDetail : Form
    {

        private UserDTO user;

        public UserDTO User

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

            //Initialize TypeComboBox with user types
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.DataSource = new List<string> { "Alumno" , "Docente" };
        }

        private async void AcceptUserButton_Click(object sender, EventArgs e)
        {
            UserApiClient client = new UserApiClient();
            IEnumerable<UserDTO> existingUsers = await UserApiClient.GetAllAsync();


            if (this.ValidateUser(existingUsers))
            {
                this.User.Name = NameTextBox.Text;
                this.User.LastName = LastNameTextBox.Text;
                this.User.Email = EmailTextBox.Text;
                this.User.Address = AddressTextBox.Text;
                this.User.Phone = PhoneTextBox.Text;
                //Legajo not implemented here
                this.User.BirthDate = BirthDatePicker.Value;
                this.User.Type = TypeComboBox.Text;
                this.User.IDPlan = int.TryParse(IDPlanComboBox.Text, out int idPlan) ? idPlan : 0;
                this.User.Username = UsernameTextBox.Text;
                this.User.Password = PasswordTextBox.Text;
                //State not implemented here

                try
                {
                    if (this.EditMode)
                    {
                        await UserApiClient.UpdateAsync(this.User);
                    }
                    else
                    {
                        await UserApiClient.AddAsync(this.User);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar Usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //Lejago not implemented here
                BirthDatePicker.Value = this.User.BirthDate > DateTimePicker.MinimumDateTime ? this.User.BirthDate : DateTime.Today;
                TypeComboBox.Text = this.User.Type;
                IDPlanComboBox.Text = this.User.IDPlan.ToString();
                UsernameTextBox.Text = this.User.Username;
                PasswordTextBox.Text = this.User.Password;
                ConfirmPasswordTextBox.Text = this.User.Password;
                //State not implemented here
            }
        }

        private bool ValidateUser(IEnumerable<UserDTO> existingUsers)
        {
            
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(NameTextBox, "El nombre es requerido");
            }
            else
            {
                errorProvider1.SetError(NameTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(LastNameTextBox, "El apellido es requerido");
            }
            else
            {
                errorProvider1.SetError(LastNameTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(EmailTextBox, "El email es requerido");
            }
            else
            {
                errorProvider1.SetError(EmailTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(AddressTextBox, "La dirección es requerida");
            }
            else
            {
                errorProvider1.SetError(AddressTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(PhoneTextBox, "El teléfono es requerido");
            }
            else
            {
                errorProvider1.SetError(PhoneTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(TypeComboBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(TypeComboBox, "El tipo es requerido");
            }
            else
            {
                errorProvider1.SetError(TypeComboBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(IDPlanComboBox.Text) || !int.TryParse(IDPlanComboBox.Text, out int idPlan) || idPlan < 1)
            {
                isValid = false;
                errorProvider1.SetError(IDPlanComboBox, "El ID del plan es requerido y debe ser un número válido mayor a 0");
            }
            else
            {
                errorProvider1.SetError(IDPlanComboBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(UsernameTextBox, "El nombre de usuario es requerido");
            }
            else
            {
                errorProvider1.SetError(UsernameTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(PasswordTextBox, "La contraseña es requerida");
            }
            else
            {
                errorProvider1.SetError(PasswordTextBox, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
            {
                isValid = false;
                errorProvider1.SetError(ConfirmPasswordTextBox, "Debe confirmar la contraseña");
            }
            else
            {
                errorProvider1.SetError(ConfirmPasswordTextBox, string.Empty);
            }

            if (existingUsers.Any(u => u.Username == UsernameTextBox.Text && u.ID != this.User?.ID))
            {
                MessageBox.Show("El nombre de usuario ya existe", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return isValid;
        }

        private async void IDPlanComboBoxData(object sender, EventArgs e)
        {
            MateriaApiClient client = new MateriaApiClient();
            List<int> idPlanes = await MateriaApiClient.GetAllIDPlanessAsync();
            IDPlanComboBox.DataSource = idPlanes;
        }

        private void IDPlanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
