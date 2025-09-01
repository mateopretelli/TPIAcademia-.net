using Data;
using Domain.Model;
using Domain.Model.Specialty;
using DTOs.Specialty;

namespace Domain.Services
{
    public class SpecialtyService
    {
        public SpecialtyDTO Add(SpecialtyDTO dto)
        {
            var specialtyRepository = new SpecialtyRepository();

            if (specialtyRepository.SpecialtyExists(dto.Descripcion))
            {
                throw new ArgumentException("Ya existe una especialidad con esa descripción.", nameof(dto.Descripcion));
            }

            Specialty specialty = new Specialty(dto.Descripcion);
            specialty.SetState("Active");

            specialtyRepository.Add(specialty);

            dto.ID = specialty.ID;
            dto.State = specialty.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var specialtyRepositry = new SpecialtyRepository();
            return specialtyRepositry.Delete(id);
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
                Descripcion = specialty.Descripcion,
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
                    Descripcion = s.Descripcion,
                    State = s.State
                }).ToList();

        }

        public bool Update(SpecialtyDTO dto)
        {
            var specialtyRePository = new SpecialtyRepository();

            if (specialtyRePository.SpecialtyExists(dto.Descripcion, dto.ID))
            {
                throw new ArgumentException("Ya existe una especialidad con esa descripción.", nameof(dto.Descripcion));
            }

            Specialty specialty = new Specialty(dto.Descripcion) {
                ID = dto.ID,
                State = dto.State
            };
            
            return specialtyRePository.Update(specialty);
        }

        public IEnumerable<SpecialtyDTO> GetByCriteria(SpecialtyCriteriaDTO criteriaDTO)
        {
            var specialtyRepository = new SpecialtyRepository();


            //Mapea DTO a Domain Model
            var criteria = new SpecialtyCriteria(criteriaDTO.Texto);

            //Llama al repositorio para obtener las especialidades
            var specialties = specialtyRepository.GetByCriteria(criteria);

            //Mapea Domain Model a DTO
            return specialties.Select(s => new SpecialtyDTO
            {
                ID = s.ID,
                Descripcion = s.Descripcion,
                State = s.State
            });
        }
    }
}
