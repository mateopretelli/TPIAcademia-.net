using Domain.Model;
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
                existingSpecialty.SetDescripcion(specialty.Descripcion);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Specialty> GetByCriteria(SpecialtyCriteria criteria)
        {
            const string sql = @"
                SELECT ID, State, Descripcion
                FROM Specialties
                WHERE Descripcion LIKE @SearchTerm 
                ORDER BY Descripcion";

            var specialties = new List<Specialty>();
            string connectionString = new TPIContext().Database.GetConnectionString();
            string searchPattern = $"%{criteria.Texto}%";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SearchTerm", searchPattern);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var specialty = new Specialty(
                    reader.GetString(2)  // Descripcion
                );

                specialty.SetId(reader.GetInt32(0)); // ID
                specialty.SetState(reader.GetString(1)); // State

                specialties.Add(specialty);
            }

            return specialties;
        }

    }
}