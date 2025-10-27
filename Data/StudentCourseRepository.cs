using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Data
{
    public class StudentCourseRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(StudentCourse studentCourse)
        {
            using var context = CreateContext();
            context.StudentCourses.Add(studentCourse);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var studentCourse = context.StudentCourses.Find(id);
            if (studentCourse != null)
            {
                context.StudentCourses.Remove(studentCourse);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public StudentCourse? Get(int id)
        {
            using var context = CreateContext();
            return context.StudentCourses
            .Include(sc => sc.Student)
            .FirstOrDefault(sc => sc.ID == id);
        }

        public IEnumerable<StudentCourse> GetAll()
        {
            using var context = CreateContext();
            return context.StudentCourses.ToList();
        }

        public bool Update(StudentCourse studentCourse)
        {
            using var context = CreateContext();

            var existingStudentCourse = context.StudentCourses.Find(studentCourse.ID);

            if (existingStudentCourse != null)
            {
                existingStudentCourse.SetGrade(studentCourse.Grade);
                existingStudentCourse.SetCondition(studentCourse.Condition);
                existingStudentCourse.SetState(studentCourse.State);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool StudentCourseExists(int studentId, int courseId, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.StudentCourses.Where(sc => sc.IDStudent == studentId && sc.IDCourse == courseId);
            if (excludeId.HasValue)
            {
                query = query.Where(sc => sc.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<StudentCourse> GetStudentCoursesWithDetailsByCourseId(int courseId)
        {
            using var context = CreateContext();
            return context.StudentCourses
                .Where(sc => sc.IDCourse == courseId)
                .Include(sc => sc.Student)
                .Include(sc => sc.Course)
                    .ThenInclude(c => c.Subject)
                .Include(sc => sc.Course)
                    .ThenInclude(c => c.Section)
                .OrderBy(sc => sc.Student.LastName)
                .ThenBy(sc => sc.Student.Name)
                .ToList();
        }

        public IEnumerable<StudentCourse> GetStudentCoursesByStudentId(int studentId)
        {
            using var context = CreateContext();
            return context.StudentCourses
                .Where(sc => sc.IDStudent == studentId)
                .Include(sc => sc.Course)
                    .ThenInclude(c => c.Subject)
                .Include(sc => sc.Course)
                    .ThenInclude(c => c.Section)
                .OrderBy(sc => sc.Course.Subject.Description)
                .ThenBy(sc => sc.Course.Section.SpecialtyYear)
                .ToList();
        }

    }
}
