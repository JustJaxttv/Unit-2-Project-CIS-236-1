using Microsoft.EntityFrameworkCore;

namespace Unit_2_Project.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Berg, David", Position = "Manager" },
                new Employee() { Id = 2, Name = "Smith, Arnold", Position = "Salesman" }
            );
        }
    }
}
