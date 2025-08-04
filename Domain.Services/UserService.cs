using Domain.Model;
using Data;

namespace Domain.Services
{
    public class UserService
    {
        public void Add(User user)
        {
            user.SetId(GetNextId());
            user.SetLegajo();
            user.SetState("Active");
            UserInMemory.Users.Add(user);
        }

        public bool Delete(int id)
        {
            User? userToDelete = UserInMemory.Users.Find(x => x.ID == id);
            if (userToDelete != null)
            {
                UserInMemory.Users.Remove(userToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }

        public User Get(int id)
        {
            var user = UserInMemory.Users.Find(x => x.ID == id);

            if (user == null)
            {
                throw new Exception($"No se encontro el usuario con id {id}");
            }

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return UserInMemory.Users.ToList();
        }

        public bool Update(User user)
        {
            User? userToUpdate = UserInMemory.Users.Find(x => x.ID == user.ID);
            if (userToUpdate != null)
            {
                userToUpdate.SetName(user.Name);
                userToUpdate.SetLastName(user.LastName);
                userToUpdate.SetEmail(user.email);
                userToUpdate.SetAddress(user.Address);
                userToUpdate.SetPhone(user.Phone);
                //userToUpdate.SetLegajo(user.Legajo);
                userToUpdate.SetBirthDate(user.birthDate);
                userToUpdate.SetIDPlan(user.IDPlan);
                userToUpdate.SetUsername(user.Username);
                userToUpdate.SetPassword(user.Password);
                userToUpdate.SetState(user.State);

                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetNextId()
        {
            if (UserInMemory.Users.Count == 0)
                return 1;
            else
                return UserInMemory.Users.Max(x => x.ID) + 1;
        }
    }
}
