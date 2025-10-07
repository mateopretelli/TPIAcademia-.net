namespace DTOs
{
    public class CourseDTO
    {
        public int ID { get; set; }
        public string State { get; set; }
        public int Capacity { get; set; }
        public int AcademicYear { get; set; }
        public int IDSection { get; set; }
        public int IDSubject { get; set; }

        public SubjectDTO Subject { get; set; } //agregado para poder acceder en cascada, capaz hay que eliminar lo de abajo e implementar este directamente

    }
}
