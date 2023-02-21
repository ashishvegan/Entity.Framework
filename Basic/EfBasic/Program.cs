using System;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeeContext())
            {
                var employee = new Employee
                {
                    FirstName = "Steve",
                    LastName = "Jobs",
                    DateOfBirth = new DateTime(2023, 10, 10),
                    Email = "example@newvision-software.com",
                    Phone = "9890098900"
                };
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }
    }
}


