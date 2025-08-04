using Domain.Model;

namespace Data
{
    public class UserInMemory
    {
        public static List<User> Users;

        static UserInMemory(){
                
                Users = new List<User>();

                User user = new User("Juan", "Pérez", "juan.perez@email.com", "Calle Falsa 123", "1123456789", 1001, new DateTime(1995, 6, 15), 1, "juanp", "password123");
                user.SetId(1);
                user.SetState("Active");
                Users.Add(user);

                user = new User("María", "Gómez", "maria.gomez@email.com", "Av. Siempre Viva 742", "1134567890", 1002, new DateTime(1992, 4, 21), 2, "mariag", "mypass456");
                user.SetId(2);
                user.SetState("Active");
                Users.Add(user);

                user = new User("Luis", "Martínez", "luis.martinez@email.com", "Calle Mitre 500", "1145678901", 1003, new DateTime(1990, 12, 10), 3, "luism", "securepass");
                user.SetId(3);
                user.SetState("Active");
                Users.Add(user);

                user = new User("Ana", "López", "ana.lopez@email.com", "Belgrano 123", "1156789012", 1004, new DateTime(1998, 9, 30), 4, "analo", "abc123");
                user.SetId(4);
                user.SetState("Active");
                Users.Add(user);

                user = new User("Carlos", "Fernández", "carlos.fernandez@email.com", "San Martín 321", "1167890123", 1005, new DateTime(1987, 1, 5), 5, "carlosf", "pass321");
                user.SetId(5);
                user.SetState("Active");
                Users.Add(user);

        }

    }
}
