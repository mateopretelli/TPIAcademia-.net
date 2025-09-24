using Domain.Model;
using Domain.Model.Specialty;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class SpecialtyRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Specialty specialty)
        {
            using var context = CreateContext();
            context.Specialties.Add(specialty);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var specialty = context.Specialties.Find(id);
            if (specialty != null)
            {
                context.Specialties.Remove(specialty);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Specialty? Get(int id)
        {
            using var context = CreateContext();
            return context.Specialties.Find(id);
        }

        public IEnumerable<Specialty> GetAll()
        {
            using var context = CreateContext();
            return context.Specialties.ToList();
        }

        public bool Update(Specialty specialty)
        {
            using var context = CreateContext();
            var existingSpecialty = context.Specialties.Find(specialty.ID);
            if (existingSpecialty != null)
            {
                existingSpecialty.SetDescription(specialty.Description);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SpecialtyExists(string descripcion, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Specialties.Where(c => c.Description.ToLower() == descripcion.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<Specialty> GetByCriteria(SearchCriteria criteria)
        {
            const string sql = @"
                SELECT ID, State, Description
                FROM Specialties
                WHERE Description LIKE @SearchTerm 
                ORDER BY Description";

            var specialties = new List<Specialty>();
            string connectionString = new TPIContext().Database.GetConnectionString();
            string searchPattern = $"%{criteria.Text}%";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SearchTerm", searchPattern);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var specialty = new Specialty(
                    reader.GetString(2)  // Description
                );

                specialty.SetId(reader.GetInt32(0)); // ID
                specialty.SetState(reader.GetString(1)); // State

                specialties.Add(specialty);
            }

            return specialties;
        }

    }
}