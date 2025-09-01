using Domain.Model.Plan;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class PlanRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Plan plan)
        {
            using var context = CreateContext();
            context.Plans.Add(plan);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var plan = context.Plans.Find(id);
            if (plan != null)
            {
                context.Plans.Remove(plan);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Plan? Get(int id)
        {
            using var context = CreateContext();
            return context.Plans.Find(id);
        }

        public IEnumerable<Plan> GetAll()
        {
            using var context = CreateContext();
            return context.Plans.ToList();
        }

        public bool Update(Plan plan)
        {
            using var context = CreateContext();
            var existingPlan = context.Plans.Find(plan.ID);
            if (existingPlan != null)
            {
                existingPlan.SetDescription(plan.Description);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool PlanExists(string description, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Plans.Where(c => c.Description.ToLower() == description.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<Plan> GetByCriteria(PlanCriteria criteria)
        {
            const string sql = @"
                SELECT ID, State, Description, IDSpecialty
                FROM Plans
                WHERE Description LIKE @SearchTerm 
                ORDER BY Description";

            var plans = new List<Plan>();
            string connectionString = new TPIContext().Database.GetConnectionString();
            string searchPattern = $"%{criteria.Texto}%";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SearchTerm", searchPattern);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var plan = new Plan(
                    reader.GetString(2),  // Descripcion
                    reader.GetInt32(3)   // ID especialidad
                );

                plan.SetId(reader.GetInt32(0)); // ID
                plan.SetState(reader.GetString(1)); // State

                plans.Add(plan);
            }

            return plans;
        }

    }
}