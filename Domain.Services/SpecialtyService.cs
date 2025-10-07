using Data;
using Domain.Model;
using DTOs;

namespace Domain.Services
{
    public class SpecialtyService
    {
        public SpecialtyDTO Add(SpecialtyDTO dto)
        {
            var specialtyRepository = new SpecialtyRepository();

            if (specialtyRepository.SpecialtyExists(dto.Description))
            {
                throw new ArgumentException("Ya existe una especialidad con esa descripción.", nameof(dto.Description));
            }

            Specialty specialty = new Specialty(dto.Description);
            specialty.SetState("Active");

            specialtyRepository.Add(specialty);

            dto.ID = specialty.ID;
            dto.State = specialty.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var specialtyRepository = new SpecialtyRepository();
            return specialtyRepository.Delete(id);
        }

        public SpecialtyDTO Get(int id)
        {
            var specialtyRepository = new SpecialtyRepository();
            Specialty? specialty = specialtyRepository.Get(id);

            if (specialty == null)
            {
                return null;
            }

            return new SpecialtyDTO
            {
                ID = specialty.ID,
                Description = specialty.Description,
                State = specialty.State
            };
        }

        public IEnumerable<SpecialtyDTO> GetAll()
        {
            var specialtyRepository = new SpecialtyRepository();
            return specialtyRepository.GetAll()
                .Select(s => new SpecialtyDTO
                {
                    ID = s.ID,
                    Description = s.Description,
                    State = s.State
                }).ToList();

        }

        public bool Update(SpecialtyDTO dto)
        {
            var specialtyRePository = new SpecialtyRepository();

            if (specialtyRePository.SpecialtyExists(dto.Description, dto.ID))
            {
                throw new ArgumentException("Ya existe una especialidad con esa descripción.", nameof(dto.Description));
            }

            Specialty specialty = new Specialty(dto.Description) {
                ID = dto.ID,
                State = dto.State
            };
            
            return specialtyRePository.Update(specialty);
        }

        public IEnumerable<SpecialtyDTO> GetByCriteria(SearchCriteriaDTO criteriaDTO)
        {
            var specialtyRepository = new SpecialtyRepository();


            //Mapea DTO a Domain Model
            var criteria = new SearchCriteria(criteriaDTO.Text);

            //Llama al repositorio para obtener las especialidades
            var specialties = specialtyRepository.GetByCriteria(criteria);

            //Mapea Domain Model a DTO
            return specialties.Select(s => new SpecialtyDTO
            {
                ID = s.ID,
                Description = s.Description,
                State = s.State
            });
        }
    }
}
