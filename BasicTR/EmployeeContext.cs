using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BasicTR 
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee>? Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ASHISHL\\SQLEXPRESS01;Database=training;User Id=;Password=;Encrypt=True;Trusted_Connection=true; TrustServerCertificate=true;");
        }
    }
}