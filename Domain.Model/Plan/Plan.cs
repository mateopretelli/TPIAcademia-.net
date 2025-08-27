using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model.Plan
{
    public class Plan : BusinessEntity
    {
        public string Description { get; private set; }

        [ForeignKey("Specialty")]
        public int IDSpecialty { get; private set; }

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
    }
}