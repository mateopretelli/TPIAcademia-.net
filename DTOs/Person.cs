

namespace DTOs
{
    public class Person
    {
        public int ID { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonalID { get; set; }
        public string Address { get; set; }
        public int IDPlan { get; set; }
        public int PersonType { get; set; } // 1: Alumno, 2: Docente, 3: Administrativo

    }
}
