namespace SoftJail.DataProcessor
{
    using AutoMapper;
    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;

    public class Deserializer
    {

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportDepartmentCellDto[] departmenDtos =
                JsonConvert.DeserializeObject<ImportDepartmentCellDto[]>(jsonString);
            ICollection<Department> validDepartments = new List<Department>();

            foreach (var depDto in departmenDtos)
            {
                if  (!IsValid(depDto))
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }
                if (!depDto.Cells.Any())
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }
                if (depDto.Cells.Any(d => !IsValid(d)))
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }
                Department department = new Department()
                {
                    Name = depDto.Name
                };
                foreach (var dCell in depDto.Cells)
                {
                    Cell cell = Mapper.Map<Cell>(dCell);
                    department.Cells.Add(cell);
                }
                validDepartments.Add(department);
                sb.AppendLine($"Imported{department.Name} with {department.Cells}");
            }

            context.Departments.AddRange(validDepartments);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            throw new NotImplementedException();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }
    }
}