using System;
using System.Linq;
using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            //string result =  GetEmployeesFullInformation(dbContext);
            // Console.WriteLine(result);

            // string res2 = GetEmployeesWithSalaryOver50000(dbContext);
            //  Console.WriteLine(res2);

            string rez3 = GetEmployeesFromResearchAndDevelopment(dbContext);
            Console.WriteLine(rez3);
        }

        // 3.	Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder output = new StringBuilder();
            var allEmplloyees = context.Employees
                .OrderBy(e => e.EmployeeId)

                .ToArray();
            foreach (var e in allEmplloyees)
            {
                output.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }

            return output.ToString().TrimEnd();
        }

        //4.	Employees with Salary Over 50 000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(employee => new
                {
                    employee.FirstName,
                    employee.Salary
                })
                .Where(s => s.Salary >= 50000)
                .ToArray()
                .OrderBy(n => n.FirstName);
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        // 5.	Employees from Research and Development

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.Employees
                .Where(d => d.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary,

                })
                .OrderBy(s => s.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToArray();
            foreach (var emp in employee)
            {
                sb.AppendLine($"{emp.FirstName} {emp.LastName} from {emp.DepartmentName} -  {emp.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
