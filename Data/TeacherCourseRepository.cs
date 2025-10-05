using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class TeacherCourseRepository
    {
        public TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(TeacherCourse teacherCourses)
        {
            TPIContext context = CreateContext();
            context.TeachersCourses.Add(teacherCourses);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var teacherCourses = context.TeachersCourses.Find(id);
            if (teacherCourses != null)
            {
                context.TeachersCourses.Remove(teacherCourses);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public TeacherCourse? Get(int id)
        {
            using var context = CreateContext();
            return context.TeachersCourses
                .Include(c => c.Teacher)
                .Include(c => c.Course)
                .FirstOrDefault(c => c.ID == id);
        }

        public IEnumerable<TeacherCourse> GetAll()
        {
            using var context = CreateContext();
            return context.TeachersCourses
                .Include(c => c.Teacher)
                .Include(c => c.Course)
                    .ThenInclude(c => c.Section)
                .Include(c => c.Course)
                    .ThenInclude(c => c.Subject)
                        .ThenInclude(p => p.Plan)
                            .ThenInclude(s => s.Specialty)
                .ToList();
        }

        public bool Update(TeacherCourse teacherCourses)
        {
            using var context = CreateContext();
            var existingTeacherCourse = context.TeachersCourses.Find(teacherCourses.ID);
            if (existingTeacherCourse != null)
            {
                existingTeacherCourse.SetIDTeacher(teacherCourses.IDTeacher);
                existingTeacherCourse.SetRole(teacherCourses.Role);
                existingTeacherCourse.SetIDCourse(teacherCourses.IDCourse);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool TeacherCourseExists(int role, int idTeacher, int idCourse, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.TeachersCourses.Where(tc=>tc.IDTeacher == idTeacher && tc.Role == role && tc.IDCourse == idCourse);
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<TeacherCourse> GetByCriteria(SearchCriteria criteria)
        {
            using var context = CreateContext();
            return context.TeachersCourses.Where(tc => tc.Teacher.Name.ToLower() == criteria.Text.ToLower() || tc.Teacher.LastName.ToLower() == criteria.Text.ToLower() || tc.Role.ToString() == criteria.Text);
        }
    }
}


