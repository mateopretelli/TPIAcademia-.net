using Data;
using Domain.Model;
using DTOs;

namespace Domain.Services
{
    public class StudentCourseService
    {
        public StudentCourseDTO Add(StudentCourseDTO dto)
        {
            var studentCourseRepository = new StudentCourseRepository();

            if (studentCourseRepository.StudentCourseExists(dto.IDstudent, dto.IDcourse))
            {
                throw new ArgumentException("El estudiante ya está inscripto en este curso.", nameof(dto.IDstudent));
            }

            StudentCourse studentCourse = new StudentCourse(dto.IDstudent, dto.IDcourse, dto.Grade ?? 0, dto.Condition);

            studentCourse.SetState("Active");
            studentCourse.SetCondition("Inscripto");

            studentCourseRepository.Add(studentCourse);

            dto.ID = studentCourse.ID;
            dto.State = studentCourse.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var studentCourseRepository = new StudentCourseRepository();
            return studentCourseRepository.Delete(id);
        }

        public StudentCourseDetailDTO Get(int id)
        {
            var studentCourseRepository = new StudentCourseRepository();
            StudentCourse? studentCourse = studentCourseRepository.Get(id);

            if (studentCourse == null)
            {
                return null;
            }

            return new StudentCourseDetailDTO
            {
                ID = studentCourse.ID,
                State = studentCourse.State,
                IDStudent = studentCourse.IDStudent,
                IDCourse = studentCourse.IDCourse,
                StudentName = studentCourse.Student.Name,
                StudentLastName = studentCourse.Student.LastName,
                StudentEmail = studentCourse.Student.Email,
                Grade = studentCourse.Grade,
                Condition = studentCourse.Condition.ToString()
            };
        }

        public IEnumerable<StudentCourseDTO> GetAll()
        {
            var studentCourseRepository = new StudentCourseRepository();

            return studentCourseRepository.GetAll()
                .Select(sc => new StudentCourseDTO
                {
                    ID = sc.ID,
                    State = sc.State,
                    IDstudent = sc.IDStudent,
                    IDcourse = sc.IDCourse,
                    Grade = sc.Grade,
                    Condition = sc.Condition.ToString()
                }).ToList();
        }

        public bool Update(StudentCourseDTO dto)
        {
            var studentCourseRepository = new StudentCourseRepository();

            if (!(studentCourseRepository.StudentCourseExists(dto.IDstudent, dto.IDcourse)))
            {
                throw new ArgumentException("No se encontró la inscripción del estudiante al curso.", nameof(dto.ID));
            }

            StudentCourse studentCourse = new StudentCourse(dto.IDstudent,dto.IDcourse,dto.Grade, dto.Condition) { 
                ID = dto.ID,
                State = dto.State
            };

            return studentCourseRepository.Update(studentCourse);
        }

        public IEnumerable<StudentCourseDetailDTO> GetStudentsDetailByCourseId(int courseId)
        {
            var studentCourseRepository = new StudentCourseRepository();
            var studentCourses = studentCourseRepository.GetStudentCoursesWithDetailsByCourseId(courseId);

            return studentCourses.Select(sc => new StudentCourseDetailDTO
            {
                ID = sc.ID,
                IDStudent = sc.IDStudent,
                IDCourse = sc.IDCourse,
                StudentName = sc.Student.Name,
                StudentLastName = sc.Student.LastName,
                StudentEmail = sc.Student.Email,
                Grade = sc.Grade,
                Condition = sc.Condition,
                State = sc.State
            });
        }

        public IEnumerable<StudentCourseDTO> GetByStudentId(int studentId)
        {
            var studentCourseRepository = new StudentCourseRepository();
            return studentCourseRepository.GetStudentCoursesByStudentId(studentId)
                .Select(sc => new StudentCourseDTO
                {
                    ID = sc.ID,
                    State = sc.State,
                    IDstudent = sc.IDStudent,
                    IDcourse = sc.IDCourse,
                    Grade = sc.Grade,
                    Condition = sc.Condition.ToString(),
                    SubjectDescription = sc.Course.Subject.Description
                }).ToList();
        }
    }
}
