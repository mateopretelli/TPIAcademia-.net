using Data;
using Domain.Model;
using Domain.Model.Section;
using Domain.Model.Subject;
using DTOs;

namespace Domain.Services
{
    public class SectionService
    {
        public SectionDTO Add(SectionDTO dto)
        {
            var sectionRepository = new SectionRepository();
            if (sectionRepository.SectionExists(dto.Description, dto.IDPlan, dto.SpecialtyYear))
            {
                throw new ArgumentException("Ya existe una comisión con esa descripcion, ese año de especialidad y plan");
            }

            Section section = new Section(dto.Description, dto.IDPlan, dto.SpecialtyYear);
            section.SetState("Active");

            sectionRepository.Add(section);

            dto.ID = section.ID;
            dto.State = section.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var sectionRepository = new SectionRepository();
            return sectionRepository.Delete(id);
        }

        public SectionDTO Get(int id) 
        {
            var sectionRepository = new SectionRepository();
            Section? section = sectionRepository.Get(id);

            if (section == null) 
            {
                return null;
            }

            return new SectionDTO
            {
                ID = section.ID,
                State = section.State,
                Description = section.Description,
                SpecialtyYear = section.SpecialtyYear,
                IDPlan = section.IDPlan
            };
        }

        public IEnumerable<SectionDTO> GetAll()
        {
            var sectionRepository = new SectionRepository();
            return sectionRepository.GetAll()
                .Select(s => new SectionDTO
                {
                    ID = s.ID,
                    State = s.State,
                    Description = s.Description,
                    SpecialtyYear = s.SpecialtyYear,
                    IDPlan = s.IDPlan
                }).ToList();
        }

        public bool Update(SectionDTO dto)
        {
            var sectionRepository = new SectionRepository();

            if (sectionRepository.SectionExists(dto.Description, dto.IDPlan, dto.SpecialtyYear, dto.ID))
            {
                throw new ArgumentException("Ya existe una comisión con esa descripcion, ese año de especialidad y plan");
            }

            Section section = new Section(dto.Description, dto.IDPlan, dto.SpecialtyYear)
            {
                ID = dto.ID,
                State = dto.State,
            };

            return sectionRepository.Update(section);
        }

        public IEnumerable<SectionDTO> GetByCriteria(SearchCriteriaDTO criteriaDTO)
        {
            var sectionRepository = new SectionRepository();

            var criteria = new SearchCriteria(criteriaDTO.Text);

            var sections = sectionRepository.GetByCriteria(criteria);

            return sections.Select(s => new SectionDTO
            {
                ID = s.ID,
                State = s.State,
                Description = s.Description,
                SpecialtyYear = s.SpecialtyYear,
                IDPlan = s.IDPlan
            });
        }

    }
}
