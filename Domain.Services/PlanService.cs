using Data;
using Domain.Model.Plan;
using DTOs.Plan;
using System.Numerics;

namespace Domain.Services
{
    public class PlanService
    {
        public PlanDTO Add(PlanDTO dto)
        {
            var planRepository = new PlanRepository();

            if (planRepository.PlanExists(dto.Description))
            {
                throw new ArgumentException("Ya existe un plan con esa descripción.", nameof(dto.Description));
            }

            Plan plan = new Plan(dto.Description, dto.IDSpecialty);
            plan.SetState("Active");

            planRepository.Add(plan);

            dto.ID = plan.ID;
            dto.State = plan.State;

            return dto;
        }

        public bool Delete(int id)
        {
            var planRepositry = new PlanRepository();
            return planRepositry.Delete(id);
        }

        public PlanDTO Get(int id)
        {
            var planRepository = new PlanRepository();
            Plan? plan = planRepository.Get(id);

            if (plan == null)
            {
                return null;
            }

            return new PlanDTO
            {
                ID = plan.ID,
                Description = plan.Description,
                IDSpecialty = plan.IDSpecialty,
                State = plan.State
            };
        }

        public IEnumerable<PlanDTO> GetAll()
        {
            var planRepository = new PlanRepository();
            return planRepository.GetAll()
                .Select(p => new PlanDTO
                {
                    ID = p.ID,
                    Description = p.Description,
                    IDSpecialty = p.IDSpecialty,
                    SpecialtyDescription = p.Specialty?.Description,
                    State = p.State
                }).ToList();

        }

        public bool Update(PlanDTO dto)
        {
            var planRePository = new PlanRepository();

            if (planRePository.PlanExists(dto.Description, dto.ID))
            {
                throw new ArgumentException("Ya existe un plan con esa descripción.", nameof(dto.Description));
            }

            Plan plan = new Plan(dto.Description, dto.IDSpecialty)
            {
                ID = dto.ID,
                State = dto.State
            };

            return planRePository.Update(plan);
        }

        public IEnumerable<PlanDTO> GetByCriteria(PlanCriteriaDTO criteriaDTO)
        {
            var planRepository = new PlanRepository();


            //Mapea DTO a Domain Model
            var criteria = new PlanCriteria(criteriaDTO.Texto);

            //Llama al repositorio para obtener las especialidades
            var specialties = planRepository.GetByCriteria(criteria);

            //Mapea Domain Model a DTO
            return specialties.Select(p => new PlanDTO
            {
                ID = p.ID,
                Description = p.Description,
                IDSpecialty = p.IDSpecialty,
                State = p.State
            });
        }
    }
}
