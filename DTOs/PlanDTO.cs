namespace DTOs
{
    public class PlanDTO
    {
        public int ID { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public int IDSpecialty { get; set; }
        public string? SpecialtyDescription { get; set; }

        public string DisplayText => $"{Description} - {SpecialtyDescription}";
    }
}
