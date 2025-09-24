using Domain.Model.Specialty;
using System.ComponentModel.DataAnnotations.Schema;
using SpecialtyEntity = Domain.Model.Specialty.Specialty;

namespace Domain.Model.Plan
{
    public class Plan : BusinessEntity
    {
        public string Description { get; private set; }

        private int _idSpecialty;
        private SpecialtyEntity _specialty;
        public int IDSpecialty
        {
            get => _specialty?.ID ?? _idSpecialty;
            private set => _idSpecialty = value;
        }
        public SpecialtyEntity Specialty
        {
            get => _specialty;
            private set
            {
                _specialty = value;
                if (value != null && _idSpecialty != value.ID)
                {
                    _idSpecialty = value.ID;
                }
            }
        }
        private Plan() { }
        public Plan(string description, int idSpecialty) 
        {
            Description = description;
            IDSpecialty = idSpecialty;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(description));
            Description = description;
        }

        public void SetIDSpecialty(int idSpecialty)
        {
            if (idSpecialty < 0)
                throw new ArgumentException("El ID de la especialidad debe ser mayor que 0.", nameof(idSpecialty));
            IDSpecialty = idSpecialty;
        }

        public void SetSpecialty(SpecialtyEntity specialty)
        {
            ArgumentNullException.ThrowIfNull(specialty);
            _specialty = specialty;
            _idSpecialty = specialty.ID;
        }
    }
}