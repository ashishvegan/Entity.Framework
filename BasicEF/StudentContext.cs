
/*
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet ef migrations add Students
    dotnet ef database update
*/
using Microsoft.EntityFrameworkCore;
namespace BasicEF
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionObject = new ConnectionString();
            var connectionString = ConnectionObject.Conn();
            optionsBuilder.UseSqlServer(connectionString);            
        }
    }
}