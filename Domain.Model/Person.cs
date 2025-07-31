using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public class Person : BusinessEntity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PhoneNumber { get; private set; }
        public int PersonalID { get; private set; }
        public string Address { get; private set; }
        public int IDPlan { get; private set; }
        public int PersonType { get; private set; }

        public Person (string name, string surname, string email, DateTime birthDate, string phoneNumber, int personalID, string address, int idPlan, int personType)
        {
            Name = name;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            PersonalID = personalID;
            Address = address;
            IDPlan = idPlan;
            PersonType = personType;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(name));
            Name = name;
        }

        public void SetSurname(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException("El apellido no puede estar vacío.", nameof(surname));
            Surname = surname;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("El correo electrónico no puede estar vacío.", nameof(email));
            Email = email;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            if (birthDate > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser futura.", nameof(birthDate));
            BirthDate = birthDate;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("El número de teléfono no puede estar vacío.", nameof(phoneNumber));
            PhoneNumber = phoneNumber;
        }

        public void SetPersonalID(int personalID) // este seria el legajo y habria que hacerlo autogenerado
        {
            if (personalID < 0)
                throw new ArgumentException("El ID personal debe ser mayor o igual a 0.", nameof(personalID));
            PersonalID = personalID;
        }

        public void SetAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("La dirección no puede estar vacía.", nameof(address));
            Address = address;
        }

        public void SetIDPlan(int idPlan)
        {
            if (idPlan < 0)
                throw new ArgumentException("El ID del plan debe ser mayor que 0.", nameof(idPlan));
            IDPlan = idPlan;

        }

        public void SetPersonType(int personType)
        {
            if (personType < 1 || personType > 3)
                throw new ArgumentException("El tipo de persona debe ser 1 (Alumno), 2 (Docente) o 3 (Administrativo).", nameof(personType));
            PersonType = personType;
        }


    }
}