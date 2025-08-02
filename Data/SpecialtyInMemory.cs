using Domain.Model;

namespace Data
{
    public class SpecialtyInMemory
    {
        public static List<Specialty> Specialties;

        static SpecialtyInMemory()
        {
            Specialties = new List<Specialty>();

            Specialty specialty = new Specialty("Ingenieria en sistemas");
            specialty.SetId(101);
            specialty.SetState("Active");
            Specialties.Add(specialty);

            specialty = new Specialty("Ingenieria en sistemas");
            specialty.SetId(102);
            specialty.SetState("Active");
            Specialties.Add(specialty);

            specialty = new Specialty("Ingenieria quimica");
            specialty.SetId(105);
            specialty.SetState("Active");
            Specialties.Add(specialty);
        }
    }
}
