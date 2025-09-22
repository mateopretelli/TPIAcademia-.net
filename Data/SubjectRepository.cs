using Domain.Model.Subject;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class SubjectRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Subject subject)
        {
            using var context = CreateContext();
            context.Subjects.Add(subject);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var subject = context.Subjects.Find(id);
            if (subject != null)
            {
                context.Subjects.Remove(subject);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Subject? Get(int id)
        {
            using var context = CreateContext();
            return context.Subjects
                .Include(c => c.Plan)
                .FirstOrDefault(c => c.ID == id);
        }

        public IEnumerable<Subject> GetAll()
        {
            using var context = CreateContext();
            return context.Subjects
                .Include(c => c.Plan)
                     .ThenInclude(p => p.Specialty)
                .ToList();
        }

        public bool Update(Subject subject)
        {
            using var context = CreateContext();
            var existingSubject = context.Subjects.Find(subject.ID);
            if (existingSubject != null)
            {
                existingSubject.SetDescription(subject.Description);
                existingSubject.SetIDPlan(subject.IDPlan);
                existingSubject.SetWeeklyHS(subject.WeeklyHS);
                existingSubject.SetTotalHS(subject.TotalHS);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SubjectExists(string description, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Subjects.Where(c => c.Description.ToLower() == description.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<Subject> GetByCriteria(SubjectCriteria criteria)
        {
            const string sql = @"
                SELECT ID, State, Description, WeeklyHS, TotalHS, IDPlan
                FROM Subjects
                WHERE Description LIKE @SearchTerm 
                ORDER BY Description";

            var subjects = new List<Subject>();
            string connectionString = new TPIContext().Database.GetConnectionString();
            string searchPattern = $"%{criteria.Text}%";

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SearchTerm", searchPattern);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var subject = new Subject(
                    reader.GetString(2),  // Description
                    reader.GetInt32(3),   // WeeklyHS
                    reader.GetInt32(4),   // TotalHS
                    reader.GetInt32(5)   // ID Plan
                );

                subject.SetId(reader.GetInt32(0)); // ID
                subject.SetState(reader.GetString(1)); // State

                subjects.Add(subject);
            }

            return subjects;
        }

    }
}