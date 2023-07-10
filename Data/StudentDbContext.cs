using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_IMS.Models;

namespace Student_IMS.Data
{
  

    public class StudentDbContext : DbContext
    {
    
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "John",
                    Surname = "Doe",
                    StudentNumber = 123456,
                    Age = 20,
                  
                },
               new Student
               {
                   Id = 2,
                   Name = "Jane",
                   Surname = "Doe",
                   StudentNumber = 654321,
                   Age = 21,
                 
               },
               new Student
               {
                   Id = 3,
                   Name = "John",
                   Surname = "Smith",
                   StudentNumber = 123654,
                   Age = 22,
                  
               },
               new Student
               {
                   Id = 4,
                   Name = "Jane",
                   Surname = "Smith",
                   StudentNumber = 321654,
                   Age = 23,
                 
               });

        }
    }
}
