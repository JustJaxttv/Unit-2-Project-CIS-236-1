using Microsoft.EntityFrameworkCore;

namespace Unit_2_Project.Models
{
    // DbContext class for database session and mapping of employee entities
    public class EmployeeDBContext : DbContext
    {
        // Contructor that passes options to base class
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }

        // Represents the Employees table
        public DbSet<Employee> Employees { get; set; }

        // Initial data for Employees table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Berg, David", Position = "Manager", Salary = 75000 },
                new Employee() { Id = 2, Name = "Smith, Arnold", Position = "Salesman", Salary = 50000 },
                new Employee() { Id = 3, Name = "Reham, Amanda", Position = "Supervisor", Salary = 62000 },
                new Employee() { Id = 4, Name = "Tylar, Darrin", Position = "Salesman", Salary = 48000 }
            );
        }
    }
}
