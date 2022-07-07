using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using P01_StudentSystem.Data.Models.EnumType;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        [Key]
        public int ResorceId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public EnumResurce.ResurceType ResurceType { get; set; }

        [Required]
        [ForeignKey(nameof(Course))]
        public int  CourseId { get; set; }
        public  Course Course  { get; set; }
    }
}
