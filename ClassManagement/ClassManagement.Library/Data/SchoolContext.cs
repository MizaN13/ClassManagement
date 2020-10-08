using ClassManagement.Library.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassManagement.Library.Data
{
    public class SchoolContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public SchoolContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Many to one relationship between Class and Student
            modelBuilder.Entity<Class>()
                .HasMany(c => c.Students)
                .WithOne(s => s.Class)
                .OnDelete(DeleteBehavior.Cascade);

            // Many to one relationship between Class and Section
            modelBuilder.Entity<Class>()
                .HasMany(c => c.Sections)
                .WithOne(sc => sc.Class)
                .OnDelete(DeleteBehavior.Cascade);

            //One to One relationship between student and department
            modelBuilder.Entity<Student>()
               .HasOne(s => s.Department)
               .WithOne(d => d.Student)
               .HasForeignKey<Student>(d => d.DepatmentId);

            modelBuilder.Entity<Student>()
                        .Property(s => s.Id)
                        .HasDefaultValueSql("newid()");
            modelBuilder.Entity<Class>()
                        .Property(c => c.Id)
                        .HasDefaultValueSql("newid()");
            modelBuilder.Entity<Section>()
                        .Property(sc => sc.Id)
                        .HasDefaultValueSql("newid()");
            modelBuilder.Entity<Department>()
                        .Property(d => d.Id)
                        .HasDefaultValueSql("newid()");

            base.OnModelCreating(modelBuilder);
        }
    }
}
