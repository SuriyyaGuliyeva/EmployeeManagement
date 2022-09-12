using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mary",
                    Department = Dept.IT,
                    Email = "mary@yahoo.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Kate",
                    Department = Dept.Payroll,
                    Email = "kate@yahoo.com"
                }
             );
        }
    }
}
