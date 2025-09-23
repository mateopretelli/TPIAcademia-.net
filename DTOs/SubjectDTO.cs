namespace DTOs
{
    public class SubjectDTO
    {
        public int ID { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public int WeeklyHS { get; set; }
        public int TotalHS { get; set; }
        public int IDPlan { get; set; }
        
        public string PlanDescription { get; set; }
    }
}