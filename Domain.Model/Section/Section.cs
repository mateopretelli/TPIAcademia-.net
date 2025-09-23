using Domain.Model.Specialty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanEntity = Domain.Model.Plan.Plan;

namespace Domain.Model.Section
{
    public class Section : BusinessEntity
    {
        public string Description { get; private set; }
        public int SpecialtyYear { get; private set; }
        private int _idPlan;
        private PlanEntity _plan;

        public int IDPlan
        {
            get => _plan?.ID ?? _idPlan;
            private set => _idPlan = value;
        }

        public PlanEntity Plan
        {
            get => _plan;

            private set
            {
                _plan = value;
                if (value != null && _idPlan != value.ID)
                {
                    _plan.ID = value.ID;
                }
            }
        }

        private Section() { }
        
        public Section(string description, int planID, int specialtyYear)
        {
            Description = description;
            _idPlan = planID;
            SpecialtyYear = specialtyYear;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(description));
            Description = description;
        }

        public void SetIDPlan(int planId)
        {
            if (planId < 0)
                throw new ArgumentException("El ID de la especialidad debe ser mayor que 0.", nameof(planId));
            _idPlan = planId;
        }

        public void SetSpecialtyYear(int year)
        {
            if (year < 1948)
                throw new ArgumentException("El año de la especialidad debe ser mayor o igual que 1948.", nameof(year));
            SpecialtyYear = year;
        }

        public void SetSpecialty(PlanEntity plan)
        {
            ArgumentNullException.ThrowIfNull(plan);
            _plan = plan;
            _idPlan = plan.ID;
        }
    }
}
