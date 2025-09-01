namespace Domain.Model.Plan
{
    public class PlanCriteria
    {
        public string Texto { get; private set; }

        public PlanCriteria(string texto)
        {
            Texto = texto.Trim();
        }
    }
}
