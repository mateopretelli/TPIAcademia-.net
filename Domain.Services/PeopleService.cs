using Domain.Model;
using Data;

namespace Domain.Services
{
    public class PeopleService
    {
        public void Add(Person person)
        {
            person.SetId(GetNextId());
            person.SetState("Active");
            PersonInMemory.People.Add(person);
        }

        public bool Delete(int id)
        {
            Person? personToDelete = PersonInMemory.People.Find(x => x.ID == id);
            if (personToDelete != null)
            {
                PersonInMemory.People.Remove(personToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Person Get(int id)
        {
            return PersonInMemory.People.Find(x => x.ID == id);
        }

        public IEnumerable<Person> GetAll()
        {
            // Return a new list each time GetAll is called
            // Ideally, this should implement a Deep Clone
            return PersonInMemory.People.ToList();
        }

        public bool Update(Person person)
        {
            Person? personToUpdate = PersonInMemory.People.Find(x => x.ID == person.ID);
            if (personToUpdate != null)
            {
                personToUpdate.SetName(person.Name);
                personToUpdate.SetSurname(person.Surname);
                personToUpdate.SetEmail(person.Email);
                personToUpdate.SetBirthDate(person.BirthDate);
                personToUpdate.SetPhoneNumber(person.PhoneNumber);
                personToUpdate.SetPersonalID(person.PersonalID);
                personToUpdate.SetAddress(person.Address);
                personToUpdate.SetIDPlan(person.IDPlan);
                personToUpdate.SetPersonType(person.PersonType);
                personToUpdate.SetState(person.State);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetNextId()
        {
            int nextId;

            if (PersonInMemory.People.Count > 0)
            {
                nextId = PersonInMemory.People.Max(x => x.ID) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
