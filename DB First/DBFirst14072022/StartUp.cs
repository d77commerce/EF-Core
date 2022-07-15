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
           string result =  GetEmployeesFullInformation(dbContext);
           Console.WriteLine(result);
        }

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
    }
}
