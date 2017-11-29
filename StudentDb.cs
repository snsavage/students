using Microsoft.EntityFrameworkCore;

namespace StudentAPI
{
    public class StudentDb : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Students.db");
        }
    }
}