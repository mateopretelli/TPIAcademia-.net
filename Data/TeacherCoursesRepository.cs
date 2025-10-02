using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    internal class TeacherCoursesRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public void Add(TeacherCourses teacherCourses)
        {
            TPIContext context = CreateContext();
            context.TeachersCourses.Add(teacherCourses);
            context.SaveChanges();
        }
    }
}
