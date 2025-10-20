using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Model;

namespace Data
{
    public class TPIContext : DbContext
    {
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<TeacherCourse> TeachersCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public TPIContext()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            //this.Database.Migrate(); 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.ToTable("Specialties");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasData(
                    new { ID = 1, State = "Active", Description = "Ingeniería en Sistemas" },
                    new { ID = 2, State = "Active", Description = "Ingeniería Industrial" },
                    new { ID = 3, State = "Active", Description = "Ingeniería Electrónica" }
                    );
            });
            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("Plans");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IDSpecialty)
                    .IsRequired()
                    .HasField("_idSpecialty");

                entity.Navigation(e => e.Specialty)
                    .HasField("_specialty");

                entity.HasOne(e => e.Specialty)
                    .WithMany()
                    .HasForeignKey(e => e.IDSpecialty);
                entity.HasData(
                    new { ID = 1, State = "Active", Description = "Plan 2020", IDSpecialty = 1 },
                    new { ID = 2, State = "Active", Description = "Plan 2019", IDSpecialty = 2 }
                    );

            });
            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subjects");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.WeeklyHS)
                    .IsRequired();

                entity.Property(e => e.TotalHS)
                    .IsRequired();

                entity.Property(e => e.IDPlan)
                    .IsRequired()
                    .HasField("_idPlan");

                entity.Navigation(e => e.Plan)
                    .HasField("_plan"); 

                entity.HasOne(e => e.Plan)
                    .WithMany()
                    .HasForeignKey(e => e.IDPlan);
                entity.HasData(
                    new { ID = 1, State = "Active", Description = "Algoritmos y Estructuras de Datos", WeeklyHS = 6, TotalHS = 96, IDPlan = 1 },
                    new { ID = 2, State = "Active", Description = "Base de Datos", WeeklyHS = 4, TotalHS = 64, IDPlan = 1 }
                );

            });
            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Sections");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SpecialtyYear)
                    .IsRequired();

                entity.Property(e => e.IDPlan)
                    .IsRequired()
                    .HasField("_idPlan");

                entity.Navigation(e => e.Plan)
                    .HasField("_plan");

                entity.HasOne(e => e.Plan)
                    .WithMany()
                    .HasForeignKey(e => e.IDPlan);
                entity.HasData(
                    new { ID = 1, State = "Active", Description = "1W2", SpecialtyYear = 2, IDPlan = 1 },
                    new { ID = 2, State = "Active", Description = "1W3", SpecialtyYear = 3, IDPlan = 1 }
                );
            });
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Courses");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Capacity)
                    .IsRequired();

                entity.Property(e => e.AcademicYear)
                    .IsRequired();

                entity.Property(e => e.IDSection)
                    .IsRequired()
                    .HasField("_idSection");

                entity.Navigation(e => e.Section)
                    .HasField("_section");

                entity.HasOne(e => e.Section)
                    .WithMany()
                    .HasForeignKey(e => e.IDSection)
                    .OnDelete(DeleteBehavior.Cascade); // mantener cascade

                entity.Property(e => e.IDSubject)
                    .IsRequired()
                    .HasField("_idSubject");

                entity.Navigation(e => e.Subject)
                    .HasField("_subject");

                entity.HasOne(e => e.Subject)
                    .WithMany()
                    .HasForeignKey(e => e.IDSubject)
                    .OnDelete(DeleteBehavior.Restrict); // cortar cascade
                entity.HasData(
                    new { ID = 1, State = "Active", Capacity = 30, AcademicYear = 2024, IDSection = 1, IDSubject = 1 },
                    new { ID = 2, State = "Active", Capacity = 25, AcademicYear = 2024, IDSection = 2, IDSubject = 2 }
                );
            });

            modelBuilder.Entity<TeacherCourse>(entity =>
            {
                entity.ToTable("TeachersCourses");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.Role)
                    .IsRequired();
                entity.Property(e => e.IDCourse)
                    .IsRequired()
                    .HasField("_idCourse");
                entity.Navigation(e => e.Course)
                    .HasField("_course");
                entity.HasOne(e => e.Course)
                    .WithMany()
                    .HasForeignKey(e => e.IDCourse)
                    .OnDelete(DeleteBehavior.Restrict);// cortar cascade
                entity.Property(e => e.IDTeacher)
                    .IsRequired()
                    .HasField("_idTeacher");
                entity.Navigation(e => e.Teacher)
                    .HasField("_teacher");
                entity.HasOne(e => e.Teacher)
                    .WithMany()
                    .HasForeignKey(e => e.IDTeacher)
                    .OnDelete(DeleteBehavior.Restrict); // cortar cascade
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);
                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.Legajo)
                    .IsRequired();
                entity.Property(e => e.BirthDate)
                    .IsRequired();
                entity.Property(e => e.Type)
                    .IsRequired();
                entity.Property(e => e.IDPlan)
                    .IsRequired(false);
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);
                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);
            
                var adminUser = new User("Admin", "System", "admin@system.com", "Main Street 123", "123456789", 1, new DateTime(1990, 1, 1), 1, null, "admin", "MSis2mIxpWL51V/vE5AyOXv1oXR44CGUYU+mNsF0wGg=", "2duaOoe0gi0sN+rhf0q2ew==");
                adminUser.SetId(1);
                adminUser.SetState("Active");
                entity.HasData(new
                {
                    ID = adminUser.ID,
                    Name = adminUser.Name,
                    LastName = adminUser.LastName,
                    Email = adminUser.Email,
                    Address = adminUser.Address,
                    Phone = adminUser.Phone,
                    Legajo = adminUser.Legajo,
                    BirthDate = adminUser.BirthDate,
                    Type = adminUser.Type,
                    IDPlan = adminUser.IDPlan,
                    Username = adminUser.Username,
                    Password = adminUser.Password, //admin (está hasheada para que no rompa los metodos de login)
                    Salt = adminUser.Salt,
                    State = adminUser.State,
                });
                var alumno1User = new User("alumno1", "alumno1apellido", "alumno1@gmail.com", "casaalumno1 1234", "123456", 1002, new DateTime(2003, 6, 20), 3, 1, "alumno1", "JTJXsTQXKssG5+A0O8olaZ/pkKziEYdCsiSrc/x3RME=", "160AhA67F0BNGG4TYlhWqQ==");
                alumno1User.SetId(2);
                alumno1User.SetState("Active");
                entity.HasData(new
                {
                    ID = alumno1User.ID,
                    Name = alumno1User.Name,
                    LastName = alumno1User.LastName,
                    Email = alumno1User.Email,
                    Address = alumno1User.Address,
                    Phone = alumno1User.Phone,
                    Legajo = alumno1User.Legajo,
                    BirthDate = alumno1User.BirthDate,
                    Type = alumno1User.Type,
                    IDPlan = alumno1User.IDPlan,
                    Username = alumno1User.Username,
                    Password = alumno1User.Password,
                    Salt = alumno1User.Salt,
                    State = alumno1User.State,
                });

                var docenteUser = new User("docente", "docenteapellido", "docente@gmail.com", "casadocente 4321", "654321", 1003, new DateTime(1990, 10, 31), 2, null, "docente", "rso6ynfxn/llN0C5iaNg5GWgTPEwXyJdK+q/YFbsJtE=", "Kf/JGvR2jfl3bfTekXqFDQ==");
                docenteUser.SetId(3);
                docenteUser.SetState("Active");
                entity.HasData(new
                {
                    ID = docenteUser.ID,
                    Name = docenteUser.Name,
                    LastName = docenteUser.LastName,
                    Email = docenteUser.Email,
                    Address = docenteUser.Address,
                    Phone = docenteUser.Phone,
                    Legajo = docenteUser.Legajo,
                    BirthDate = docenteUser.BirthDate,
                    Type = docenteUser.Type,
                    IDPlan = docenteUser.IDPlan,
                    Username = docenteUser.Username,
                    Password = docenteUser.Password,
                    Salt = docenteUser.Salt,
                    State = docenteUser.State,
                });

                var alumno2User = new User("alumno2", "alumno2", "alumno2@gmail.com", "casaalumno 2987", "987654", 1004, new DateTime(2004, 10, 20), 3, 1, "alumno2", "d9/WWuMBjON/J+kEdgV2BcSxoUBjRswZFgGrkI+2gOM=", "58KgV1doRC/OBPJRB7gb7Q==");
                alumno2User.SetId(4);
                alumno2User.SetState("Active");
                entity.HasData(new
                {
                    ID = alumno2User.ID,
                    Name = alumno2User.Name,
                    LastName = alumno2User.LastName,
                    Email = alumno2User.Email,
                    Address = alumno2User.Address,
                    Phone = alumno2User.Phone,
                    Legajo = alumno2User.Legajo,
                    BirthDate = alumno2User.BirthDate,
                    Type = alumno2User.Type,
                    IDPlan = alumno2User.IDPlan,
                    Username = alumno2User.Username,
                    Password = alumno2User.Password,
                    Salt = alumno2User.Salt,
                    State = alumno2User.State,
                });

                var alumno3User = new User("alumno3", "alumno3", "alumno3@gmail.com", "casaalumno 3456", "765432", 1005, new DateTime(2004, 11, 13), 3, 1, "alumno3", "/YQKfcEUKC8HydM6Jb08uMBjKwvaCQ6dZ3drEtZDhhA=", "4rvFzSSuxOnhpIWoE7qQMQ==");
                alumno3User.SetId(5);
                alumno3User.SetState("Active");
                entity.HasData(new
                {
                    ID = alumno3User.ID,
                    Name = alumno3User.Name,
                    LastName = alumno3User.LastName,
                    Email = alumno3User.Email,
                    Address = alumno3User.Address,
                    Phone = alumno3User.Phone,
                    Legajo = alumno3User.Legajo,
                    BirthDate = alumno3User.BirthDate,
                    Type = alumno3User.Type,
                    IDPlan = alumno3User.IDPlan,
                    Username = alumno3User.Username,
                    Password = alumno3User.Password,
                    Salt = alumno3User.Salt,
                    State = alumno3User.State,
                });
            });


            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.ToTable("StudentCourses");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.Grade)
                    .IsRequired();
                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.IDStudent)
                    .IsRequired()
                    .HasField("_idStudent");
                entity.Navigation(e => e.Student)
                    .HasField("_student");
                entity.HasOne(e => e.Student)
                    .WithMany()
                    .HasForeignKey(e => e.IDStudent)
                    .OnDelete(DeleteBehavior.Restrict); // cortar cascade
                entity.Property(e => e.IDCourse)
                    .IsRequired()
                    .HasField("_idCourse");
                entity.Navigation(e => e.Course)
                    .HasField("_course");
                entity.HasOne(e => e.Course)
                    .WithMany()
                    .HasForeignKey(e => e.IDCourse)
                    .OnDelete(DeleteBehavior.Cascade); // mantener cascade
            });
        }
    }
}
