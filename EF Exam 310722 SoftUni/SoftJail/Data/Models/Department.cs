using SoftJail.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.Data.Models
{
   public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ValidationConstans.DepartmentMax)]
        public string Name { get; set; }
    }
}
