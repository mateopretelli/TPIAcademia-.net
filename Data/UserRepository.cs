using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class UserRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(User user)
        {
            using var context = CreateContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public User? Get(int id)
        {
            using var context = CreateContext();
            return context.Users.Find(id);
        }

        public User? GetByUsername(string username)
        {
            using var context = CreateContext();
            return context.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());
        }

        public User? GetByLegajo(int legajo)
        {
            using var context = CreateContext();
            return context.Users.FirstOrDefault(u => u.Legajo == legajo);
        }
        public IEnumerable<User> GetAll()
        {
            using var context = CreateContext();
            return context.Users.ToList();
        }

        public bool Update(User user)
        {
            using var context = CreateContext();
            var existingUser = context.Users.Find(user.ID);
            if (existingUser != null)
            {
                existingUser.SetName(user.Name);
                existingUser.SetLastName(user.LastName);
                existingUser.SetEmail(user.Email);
                existingUser.SetAddress(user.Address);
                existingUser.SetPhone(user.Phone);
                existingUser.SetBirthDate(user.BirthDate);
                existingUser.SetType(user.Type);
                existingUser.SetIDPlan(user.IDPlan);
                existingUser.SetLegajo();
                existingUser.SetUsername(user.Username);
                existingUser.SetPassword(user.Password);
                existingUser.SetSalt(user.Salt);
                existingUser.SetState(user.State);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UserExists(string username, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Users.Where(c => c.Username.ToLower() == username.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<User> GetByCriteria(SearchCriteria criteria)
        {
            const string sql = @"
                SELECT ID, Name, Lastname, Email, Adress, Phone, Legajo, BirthDate, Type, IDPlan, Username, Password, State
                FROM Users
                WHERE Email LIKE @SearchTerm 
                ORDER BY Email";

            var users = new List<User>();
            string connectionString = new TPIContext().Database.GetConnectionString();
            string searchPattern = $"%{criteria.Text}%";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SearchTerm", searchPattern);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var user = new User(
                    reader.GetString(2),  // Name
                    reader.GetString(3),  // LastName
                    reader.GetString(4),  // Email
                    reader.GetString(5),  // Address
                    reader.GetString(6),  // Phone
                    reader.GetInt32(7),   // Legajo
                    reader.GetDateTime(8), // BirthDate
                    reader.GetInt32(9),  // Type
                    reader.GetInt32(10),  // IDPlan
                    reader.GetString(11), // Username
                    reader.GetString(12), // Password
                    reader.GetString(13) //Salt
                );

                user.SetId(reader.GetInt32(0)); // ID
                user.SetState(reader.GetString(1)); // State

                users.Add(user);
            }

            return users;
        }

    }
}
