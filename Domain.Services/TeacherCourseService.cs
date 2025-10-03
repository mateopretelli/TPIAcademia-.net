using Data;
using Domain.Model;
using DTOs;

namespace Domain.Services
{
    public class TeacherCourseService
    {
        public TeacherCourseDTO Add(TeacherCourseDTO dto)
        {
            var teacherCourseRepository = new TeacherCourseRepository();
            if (teacherCourseRepository.TeacherCourseExists(dto.Role, dto.IDTeacher, dto.IDCourse))
            {
                throw new ArgumentException("Ya existe un docente de ese curso");
            }
            TeacherCourse teacherCourse = new TeacherCourse(dto.Role, dto.IDTeacher, dto.IDCourse);
            teacherCourse.SetState("Active");

            teacherCourseRepository.Add(teacherCourse);

            dto.ID = teacherCourse.ID;
            dto.State = teacherCourse.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var teacherCourseRepository = new TeacherCourseRepository();
            return teacherCourseRepository.Delete(id);
        }

        public TeacherCourseDTO Get(int id)
        {
            var teacherCourseRepository = new TeacherCourseRepository();
            TeacherCourse? teacherCourse = teacherCourseRepository.Get(id);

            if (teacherCourse == null)
            {
                return null;
            }

            return new TeacherCourseDTO
            {
                ID = teacherCourse.ID,
                State = teacherCourse.State,
                Role = teacherCourse.Role,
                IDTeacher = teacherCourse.IDTeacher,
                IDCourse = teacherCourse.IDCourse
            };
        }

        public IEnumerable<TeacherCourseDTO> GetAll()
        {
            var teacherCourseRepository = new TeacherCourseRepository();
            return teacherCourseRepository.GetAll()
                .Select(tc => new TeacherCourseDTO
                {
                    ID = tc.ID,
                    State = tc.State,
                    Role = tc.Role,
                    IDTeacher = tc.IDTeacher,
                    IDCourse = tc.IDCourse
                }).ToList();
        }

        public bool Update(TeacherCourseDTO dto)
        {
            var teacherCourseRepository = new TeacherCourseRepository();

            if (teacherCourseRepository.TeacherCourseExists(dto.Role, dto.IDTeacher, dto.IDCourse, dto.ID))
            {
                throw new ArgumentException("Ya existe un docente de ese curso");
            }

            TeacherCourse teacherCourse = new TeacherCourse(dto.Role, dto.IDTeacher, dto.IDCourse)
            {
                ID = dto.ID,
                State = dto.State,
            };

            return teacherCourseRepository.Update(teacherCourse);
        }

        public IEnumerable<TeacherCourseDTO> GetByCriteria(SearchCriteriaDTO criteriaDTO)
        {
            var teacherCourseRepository = new TeacherCourseRepository();

            var criteria = new SearchCriteria(criteriaDTO.Text);

            var teacherCourses = teacherCourseRepository.GetByCriteria(criteria);

            return teacherCourses.Select(tc => new TeacherCourseDTO
            {
                ID = tc.ID,
                State = tc.State,
                Role = tc.Role,
                IDTeacher = tc.IDTeacher,
                IDCourse = tc.IDCourse
            });
        }

    }
}

