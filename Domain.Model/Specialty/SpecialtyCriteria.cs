namespace Domain.Model.Specialty
{
    public class SpecialtyCriteria
    {
        public string Texto { get; private set; }

        public SpecialtyCriteria(string texto)
        {
            Texto = texto.Trim();
        }
    }
}
