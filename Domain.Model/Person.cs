namespace Domain.Model
{ 
    public class Person : BusinessEntity
    {

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public int Legajo { get; private set; }
        public DateTime BirthDate { get; private set; }

        private TypesPeople _type;

        public int Type
        {
            get => (int)_type;
            set => _type = (TypesPeople)value;
        }
        public int? IDPlan { get; private set; }

        public Person() { }
        public Person(string name, string lastName, string email, string address, string phone, int legajo, DateTime birthDate, int type, int? idPlan)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Address = address;
            Phone = phone;
            Legajo = legajo;
            BirthDate = birthDate;
            Type = type;
            IDPlan = idPlan;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(name));
            Name = name;
        }

        public void SetLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("El apellido no puede estar vacío.", nameof(lastName));
            LastName = lastName;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("El email no puede estar vacío.", nameof(email));
            Email = email;
        }

        public void SetAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("La dirección no puede estar vacía.", nameof(address));
            Address = address;
        }

        public void SetPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("El teléfono no puede estar vacío.", nameof(phone));
            Phone = phone;
        }

        public void SetLegajo() 
        {
            Legajo = ID + 1000;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            if (birthDate > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser fuTURA.", nameof(birthDate));
            BirthDate = birthDate;
        }

        public void SetType(int type)
        {
            if ( type <= 0)
                throw new ArgumentException("El tipo no puede estar vacío.", nameof(type));
            Type = type;
        }

        public void SetIDPlan(int? idPlan)
        {
            if (idPlan == null)
            {
                if (idPlan < 0)
                    throw new ArgumentException("El ID del plan debe ser mayor o igual a 0.", nameof(idPlan));
                IDPlan = idPlan;
            }

        }


    }
}
