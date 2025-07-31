using Domain.Model;

namespace Data
{
    public class PersonInMemory
    {
        public static List<Person> People;

        static PersonInMemory() { 
            
            People = new List<Person>();

            Person person1 = new Person(
                "Juan",
                "Pérez",
                "juan.perez@example.com",
                new DateTime(2000, 5, 15),
                "1123456789",
                1001,
                "Calle Falsa 123",
                1,    // idPlan
                1     // tipo_persona: Alumno
            );

            Person person2 = new Person(
                "María",
                "Gómez",
                "maria.gomez@example.com",
                new DateTime(1985, 10, 20),
                "1198765432",
                1002,
                "Av. Siempre Viva 742",
                2,    // idPlan
                2     // tipo_persona: Docente
            );

            Person person3 = new Person(
                "Carlos",
                "Ramírez",
                "carlos.ramirez@example.com",
                new DateTime(1995, 3, 8),
                "1133344455",
                1003,
                "San Martín 456",
                1,
                1
            );

            Person person4 = new Person(
                "Laura",
                "Fernández",
                "laura.fernandez@example.com",
                new DateTime(1990, 7, 22),
                "1144455566",
                1004,
                "Mitre 789",
                3,
                3     // tipo_persona: Administrativo
            );

            Person person5 = new Person(
                "Pedro",
                "López",
                "pedro.lopez@example.com",
                new DateTime(2002, 12, 5),
                "1177788899",
                1005,
                "Belgrano 321",
                1,
                1
            );

        }
    }
}
