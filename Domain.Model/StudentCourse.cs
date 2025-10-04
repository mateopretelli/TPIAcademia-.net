using StudentEntity = Domain.Model.User.User;
using CourseEntity = Domain.Model.Course.Course;

namespace Domain.Model
{
    public class StudentCourse : BusinessEntity
    {

        private int _idStudent;
        private StudentEntity _student;
        public int IDStudent
        {
            get => _idStudent;
            private set => _idStudent = value;
        }
        public StudentEntity Student { 
            get => _student;
            private set
            {
                _student = value;
                if (value != null && _idStudent != value.ID)
                {
                    _idStudent = value.ID;
                }
            }

        }
        private int _idCourse;
        private CourseEntity _course;
        public int IDCourse
        {
            get => _idCourse;
            private set => _idCourse = value;
        }
        public CourseEntity Course
        {
            get => _course;
            private set
            {
                _course = value;
                if (value != null && _idCourse != value.ID)
                {
                    _idCourse = value.ID;
                }
            }
        }
        public int Grade { get; private set; }
        public enum ConditionType { Regular, Libre, Aprobado, Inscripto}
        public ConditionType Condition { get; private set; }
        public StudentCourse() : base() { }
        public StudentCourse(int idStudent, int idCourse, int grade, string condition)
        {
            IDStudent = idStudent;
            IDCourse = idCourse;
            Grade = grade;
            Condition = condition;
        }

        public void SetIDStudent(int idStudent)
        {
            if (idStudent < 0)
                throw new ArgumentException("El ID del estudiante debe ser mayor que 0.", nameof(idStudent));
            IDStudent = idStudent;
        }

        public void SetStudent(StudentEntity student)
        {
            ArgumentNullException.ThrowIfNull(student);
            Student = student; //checkear
        }

        public void SetIDCourse(int idCourse)
        {
            if (idCourse < 0)
                throw new ArgumentException("El ID del curso debe ser mayor que 0.", nameof(idCourse));
            IDCourse = idCourse;
        }

        public void SetCourse(CourseEntity course)
        {
            ArgumentNullException.ThrowIfNull(course);
            Course = course; //checkear
        }

        public void SetGrade(int grade)
        {
            if (grade < 0 || grade > 10)
                throw new ArgumentException("La nota debe estar entre 0 y 10.", nameof(grade));
            Grade = grade;
        }

        public void SetCondition(string condition)
        {
            if (string.IsNullOrWhiteSpace(condition))
                throw new ArgumentException("La condición no puede estar vacía.", nameof(condition));
            Condition = condition;
        }


    }
}
