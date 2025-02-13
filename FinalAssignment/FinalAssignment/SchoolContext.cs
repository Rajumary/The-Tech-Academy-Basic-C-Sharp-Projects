using System.Data.Entity;

namespace FinalAssignment
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
