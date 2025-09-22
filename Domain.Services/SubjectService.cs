using Data;
using Domain.Model.Subject;
using DTOs.Subject;

namespace Domain.Services
{
    public class SubjectService
    {
        public SubjectDTO Add(SubjectDTO dto)
        {
            var subjectRepository = new SubjectRepository();
            if (subjectRepository.SubjectExists(dto.Description))
            {
                throw new ArgumentException("Ya existe una materia con esa descripción");
            }

            Subject subject = new Subject(dto.Description, dto.WeeklyHS, dto.TotalHS, dto.IDPlan);
            subject.SetState("Active");

            subjectRepository.Add(subject);

            dto.ID = subject.ID;
            dto.State = subject.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var subjectRepository = new SubjectRepository();
            return subjectRepository.Delete(id);
        }

        public SubjectDTO Get(int id)
        {
            var subjectRepository = new SubjectRepository();
            Subject? subject = subjectRepository.Get(id);

            if(subject == null)
            {
                return null;
            }

            return new SubjectDTO
            {
                ID = subject.ID,
                State = subject.State,
                Description = subject.Description,
                WeeklyHS = subject.WeeklyHS,
                TotalHS = subject.TotalHS,
                IDPlan = subject.IDPlan
            };
        }

        public IEnumerable<SubjectDTO> GetAll()
        {
            var subjectRepository = new SubjectRepository();
            return subjectRepository.GetAll()
                .Select( s => new SubjectDTO
            {
                ID = s.ID,
                State = s.State,
                Description = s.Description,
                WeeklyHS = s.WeeklyHS,
                TotalHS = s.TotalHS,
                IDPlan = s.IDPlan,
                PlanDescription = s.Plan?.Description,
            }).ToList();
            
        }

        public bool Update(SubjectDTO dto)
        {
            var subjectRepository = new SubjectRepository();

            if(subjectRepository.SubjectExists(dto.Description, dto.ID))
            {
                throw new ArgumentException("Ya existe una materia con esa descripcion");
            }

            Subject subject = new Subject(dto.Description, dto.WeeklyHS, dto.TotalHS, dto.IDPlan)
            {
                ID = dto.ID,
                State = dto.State,
            };

            return subjectRepository.Update(subject);
        }
     
        public IEnumerable<SubjectDTO> GetByCriteria(SubjectCriteriaDTO criteriaDTO)
        {
            var subjectRepository = new SubjectRepository();

            var criteria = new SubjectCriteria(criteriaDTO.Text);

            var subjects = subjectRepository.GetByCriteria(criteria);

            return subjects.Select(s => new SubjectDTO{
                ID = s.ID,
                State = s.State,
                Description= s.Description,
                WeeklyHS = s.WeeklyHS,
                TotalHS= s.TotalHS,
                IDPlan = s.IDPlan
            });
        }
    }
}
