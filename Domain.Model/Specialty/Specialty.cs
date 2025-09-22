namespace Domain.Model.Specialty
{
    public class Specialty : BusinessEntity
    {
        public string Description { get; private set; }

        public Specialty(string description)
        {
            Description = description;
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("La descripción no puede estar vacía.", nameof(description));
            Description = description;
        }
    }
}