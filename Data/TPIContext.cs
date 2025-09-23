using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection.Emit;
using Domain.Model.Plan;
using Domain.Model.Specialty;
using Domain.Model.User;
using Domain.Model.Subject;

namespace Data
{
    public class TPIContext : DbContext
    {
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
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
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.IDPlan)
                    .IsRequired();
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);
            });
        }
    }
}
