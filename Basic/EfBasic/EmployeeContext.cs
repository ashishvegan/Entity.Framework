
using Microsoft.EntityFrameworkCore;
namespace EmployeeDetails
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee>? Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ASHISHL\\SQLEXPRESS01;Database=training_mig;User Id=;Password=;Encrypt=True;Trusted_Connection=true; TrustServerCertificate=true;");

        }
    }
}

