using Domain.Model.Course;
using CourseEntity = Domain.Model.Course.Course;
using PersonEntity = Domain.Model.Person.Person;

namespace Domain.Model
{
    public class TeacherCourse: BusinessEntity
    {
        private TypesRoles _role;

        public int Role
        {
            get => (int)_role;
            set => _role = (TypesRoles)value;
        }

        private int _idCourse;
        private CourseEntity _course;

        public int IDCourse
        {
            get => _course?.ID ?? _idCourse;
            private set => _idCourse = value;
        }

        public CourseEntity Course
        {
            get => _course;
            private set
            {
                _course = value;
                if(value != null && _idCourse != value.ID)
                {
                    _idCourse = value.ID;
                }
            }
        }

        private int _idTeacher;
        private PersonEntity _teacher;

        public int IDTeacher
        {
            get=>_teacher?.ID ?? _idTeacher;
            private set => _idCourse = value;
        }

        public PersonEntity Teacher
        {
            get => _teacher;
            private set
            {
                _teacher = value;
                if(value != null && _idTeacher != value.ID)
                {
                    _idTeacher = value.ID;
                }
            }
        }

        private TeacherCourse() { }

        public TeacherCourse(int role,int courseId, int teacherId)
        { 
            SetIDCourse(courseId);
            SetIDTeacher(teacherId);
            SetRole(role);
        }

        public void SetIDCourse(int courseId)
        {
            if(courseId > 0) {_idCourse = courseId;}
            else
            {
                throw new ArgumentException("El ID del curso debe ser mayor que 0.", nameof(courseId));
            }
        }

        public void SetIDTeacher(int teacherId) 
        {
            if (teacherId > 0) { _idTeacher = teacherId; }
            else
            {
                throw new ArgumentException("El ID del docente debe ser mayor que 0.", nameof(teacherId));
            }
        }

        public void SetRole(int newRole)
        {
            if (newRole < 0)
                throw new ArgumentException("El cargo debe ser válido.", nameof(newRole));
            Role = newRole;
        }

    }
}
