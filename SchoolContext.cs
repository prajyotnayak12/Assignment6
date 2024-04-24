using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Marksheet> Marksheets { get; set; }
        public SchoolContext(DbContextOptions options) : base(options)
       {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("your_connection_string");
        }
      }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Prajyot", StudentJoinDate = new DateTime(2022, 1, 1) },
                new Student { StudentId = 2, StudentName = "Prajyo", StudentJoinDate = new DateTime(2022, 2, 1) },
                new Student { StudentId = 3, StudentName = "Prajy", StudentJoinDate = new DateTime(2022, 3, 1) },
                new Student { StudentId = 4, StudentName = "Praj", StudentJoinDate = new DateTime(2022, 4, 1) },
                new Student { StudentId = 5, StudentName = "Pra", StudentJoinDate = new DateTime(2022, 5, 1) }
            );

            modelBuilder.Entity<Marksheet>().HasData(
                new Marksheet { MarkSheetId = 1, StudentId = 1, MarksObtained = 85, TotalMark = 100 },
                new Marksheet { MarkSheetId = 2, StudentId = 2, MarksObtained = 75, TotalMark = 100 },
                new Marksheet { MarkSheetId = 3, StudentId = 3, MarksObtained = 90, TotalMark = 100 },
                new Marksheet { MarkSheetId = 4, StudentId = 4, MarksObtained = 60, TotalMark = 100 },
                new Marksheet { MarkSheetId = 5, StudentId = 5, MarksObtained = 95, TotalMark = 100 }
            );
        }
    }
}

        
       
        
            
        
    
