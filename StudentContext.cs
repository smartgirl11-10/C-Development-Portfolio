using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StudentCodeFirst
{
    public class StudentContext : DbContext
    {
        // Parameterless constructor that provides a sensible default (in-memory DB)
        public StudentContext()
            : base(new DbContextOptionsBuilder<StudentContext>()
                   .UseInMemoryDatabase("StudentDB")
                   .Options)
        {
        }

        // Existing constructor for DI / production configuration
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}