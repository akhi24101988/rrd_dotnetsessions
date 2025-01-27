using EmployeeManagementApp.Models;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer = new Developer(10000);
            Employee manager = new Manager(50000);

            PrintSalarySlip(developer);
            PrintSalarySlip(manager);

        }

        static void PrintSalarySlip(Employee employee)
        {
            Console.WriteLine($"Basic Salary: {employee.EmployeeType()} :{employee.BasicSalary}");
            Console.WriteLine(employee.GetDetails());
        }
    }
}