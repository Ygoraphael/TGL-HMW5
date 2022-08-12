using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            Student[] StudentSeed = new Student[10];

            for (int i = 1; i < 11; i++)
            {
                StudentSeed[i-1] = new Student
                {
                    StudentId = i,
                    Name = "Name"+i.ToString(),
                    Email = "email"+i.ToString()+"@gmail.com"
                };
            }

            modelBuilder.Entity<Student>().HasData(StudentSeed);*/
        }
    }
}
