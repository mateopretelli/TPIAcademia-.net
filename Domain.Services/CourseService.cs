using Data;
using Domain.Model;
using Domain.Model.Course;
using DTOs;

namespace Domain.Services
{
    public class CourseService
    {
        public CourseDTO Add(CourseDTO dto)
        {
            var courseRepository = new CourseRepository();
            if (courseRepository.CourseExists(dto.Capacity, dto.AcademicYear, dto.IDSection, dto.IDSubject))
            {
                throw new ArgumentException("Ya existe un curso con ese año académico, materia y plan");
            }
            Course course = new Course(dto.Capacity, dto.AcademicYear, dto.IDSection, dto.IDSubject);
            course.SetState("Active");

            courseRepository.Add(course);

            dto.ID = course.ID;
            dto.State = course.State;

            

            return dto;
        }

        public bool Delete(int id)
        {
            var courseRepository = new CourseRepository();
            return courseRepository.Delete(id);
        }

        public CourseDTO Get(int id)
        {
            var courseRepository = new CourseRepository();
            Course? course = courseRepository.Get(id);

            if (course == null)
            {
                return null;
            }

            return new CourseDTO
            {
                ID = course.ID,
                State = course.State,
                Capacity = course.Capacity,
                AcademicYear = course.AcademicYear,
                IDSubject = course.IDSubject,
                IDSection = course.IDSection
            };
        }

        public IEnumerable<CourseDTO> GetAll()
        {
            var courseRepository = new CourseRepository();
            return courseRepository.GetAll()
                .Select(c => new CourseDTO
                {
                    ID = c.ID,
                    State = c.State,
                    Capacity = c.Capacity,
                    AcademicYear = c.AcademicYear,
                    IDSubject = c.IDSubject,
                    IDSection = c.IDSection
                }).ToList();
        }

        public bool Update(CourseDTO dto)
        {
            var courseRepository = new CourseRepository();

            if (courseRepository.CourseExists(dto.Capacity, dto.AcademicYear, dto.IDSection, dto.IDSubject, dto.ID))
            {
                throw new ArgumentException("Ya existe un curso con ese año académico, materia y plan");
            }

            Course course = new Course(dto.Capacity, dto.AcademicYear, dto.IDSection, dto.IDSubject)
            {
                ID = dto.ID,
                State = dto.State,
            };

            return courseRepository.Update(course);
        }

        public IEnumerable<CourseDTO> GetByCriteria(SearchCriteriaDTO criteriaDTO)
        {
            var courseRepository = new CourseRepository();

            var criteria = new SearchCriteria(criteriaDTO.Text);

            var courses = courseRepository.GetByCriteria(criteria);

            return courses.Select(c => new CourseDTO
            {
                ID = c.ID,
                State = c.State,
                Capacity = c.Capacity,
                AcademicYear = c.AcademicYear,
                IDSubject = c.IDSubject,
                IDSection = c.IDSection
            });
        }

    }
}
