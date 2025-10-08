namespace Domain.Model
{
    public class User : Person
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Salt { get; private set; }

        public User(): base() {}
        public User(string name, string lastName, string email, string address, string phone, int legajo, DateTime birthDate,int type, int? idPlan, string username, string password, string salt)
            : base(name, lastName, email, address, phone, legajo, birthDate, type, idPlan)
        {
            Username = username;
            Password = password;
            Salt = salt;
        }

        public void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.", nameof(username));
            Username = username;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña no puede estar vacía.", nameof(password));
            Password = password;
        }

        public void SetSalt(string salt)
        {
            if (string.IsNullOrWhiteSpace(salt))
                throw new ArgumentException("El salt no puede estar vacío.", nameof(salt));
            Salt = salt;
        }
    }
}
