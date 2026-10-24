using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorialsConsole
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Kết nối tới LocalDB theo đúng slide
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}