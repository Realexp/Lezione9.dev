using Microsoft.EntityFrameworkCore;

namespace dbacasas.Entity
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(): base() { }
        public UniversityDbContext(DbContextOptions<UniversityDbContext> utils): base(utils) { }

        public DbSet<Student> Students  { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
