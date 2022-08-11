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
    using System.Globalization;
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
                if (!IsValid(depDto))
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
                sb.AppendLine($"Imported{department.Name} with {department.Cells.Count} cells");
            }

            context.Departments.AddRange(validDepartments);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportPrisonersAndMailsDto[] prisonersDtos =
                JsonConvert.DeserializeObject<ImportPrisonersAndMailsDto[]>(jsonString);

            foreach (var prisonerDto in prisonersDtos)
            {
                if (!IsValid(prisonerDto))
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }

                if (!IsValid(prisonerDto.Mails))
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }
                if (prisonerDto.Mails.Any(mDto => !IsValid(mDto)))
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }

                bool isValidIncarcerationDate = DateTime.TryParseExact(prisonerDto.IncarcerationDate, "dd,MM,yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime incarcerationDate);

            }



            return "one";
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