namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeeContext())
            {
                var Employee = new Employee
                {
                    FirstName = "John",
                    LastName = "Cameron",
                    DateOfBirth = new DateTime(2023, 01, 02),
                    Email = "example@newvision-software.com",
                    Phone = "9890098900"
                };
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }
    }
}