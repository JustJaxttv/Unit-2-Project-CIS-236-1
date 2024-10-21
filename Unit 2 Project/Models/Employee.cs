namespace Unit_2_Project.Models
{
    // Employee model that represents an Employee from the database
    public class Employee
    {
        // Primary Key
        public int Id { get; set; }

        // Employee Name
        public string? Name { get; set; }

        // Employee Job Title
        public string? Position { get; set; }

        // Employee Salary
        public decimal? Salary { get; set; }
    }
}
