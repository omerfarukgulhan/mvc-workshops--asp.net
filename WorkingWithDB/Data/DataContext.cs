using Microsoft.EntityFrameworkCore;

namespace WorkingWithDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<CourseRegistration> CourseRegistrations => Set<CourseRegistration>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
    }
}
