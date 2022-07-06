using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        public bool RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }

        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public ICollection<Course> Courses { get; set; }

        public int HomeworkId   { get; set; }

        public ICollection<home>

    }
}
