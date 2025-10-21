using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CourseRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(Course course)
        {
            using var context = CreateContext();
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var course = context.Courses.Find(id);
            if (course != null)
            {

                var teachersCourses = context.TeachersCourses
                .Where(tc => tc.IDCourse == id)
                .ToList();

                context.TeachersCourses.RemoveRange(teachersCourses);

                var studentCourses = context.StudentCourses
                .Where(tc => tc.IDCourse == id)
                .ToList();

                context.TeachersCourses.RemoveRange(teachersCourses);
                context.StudentCourses.RemoveRange(studentCourses);

                context.Courses.Remove(course);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Course? Get(int id)
        {
            using var context = CreateContext();
            return context.Courses
                .Include(c => c.Section)
                .Include(c => c.Subject)
                .FirstOrDefault(c => c.ID == id);
        }

        public IEnumerable<Course> GetAll()
        {
            using var context = CreateContext();
            return context.Courses
                .Include(c => c.Section)
                .Include(c => c.Subject)
                    .ThenInclude(s => s.Plan)
                        .ThenInclude(p => p.Specialty)
                .ToList();
        }

        public IEnumerable<Course> GetAllBySubject(int idSubject)
        {
            using var context = CreateContext();
            return context.Courses
                .Include(c => c.Section)
                .Include(c => c.Subject)
                    .ThenInclude(s => s.Plan)
                        .ThenInclude(p => p.Specialty)
                .Where(c => c.IDSubject == idSubject)
                .ToList();
        }
        public bool Update(Course course)
        {
            using var context = CreateContext();
            var existingCourse = context.Courses.Find(course.ID);
            if (existingCourse != null)
            {
                existingCourse.SetCapacity(course.Capacity);
                existingCourse.SetIDSection(course.IDSection);
                existingCourse.SetAcademicYear(course.AcademicYear);
                existingCourse.SetIDSubject(course.IDSubject);
                existingCourse.SetState(course.State);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CourseExists(int capacity, int idSection, int academicYear, int idSubject, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Courses.Where(c => c.Capacity == capacity && c.IDSection == idSection && c.AcademicYear == academicYear && c.IDSubject == idSubject);
            if (excludeId.HasValue)
            {
                query = query.Where(s => s.ID != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<Course> GetByCriteria(SearchCriteria criteria)
        {
            using var context = CreateContext();
            return context.Courses.Where(c => c.Subject.Description.ToLower() == criteria.Text || c.Section.Description.ToLower() == criteria.Text || c.AcademicYear.ToString() == criteria.Text);
        }
    }
}
