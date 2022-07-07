using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {

        public Course()
        {
            this.Resources = new HashSet<Resource>();
            this.StudentEnrollment = new HashSet<StudentCourse>();
            this.HomeworkSubmissions = new HashSet<Homework>();
        }
        [Key]
        public int CourseId { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public virtual ICollection<Resource> Resources { get; set; }

        [Required]
        public virtual ICollection<StudentCourse>StudentEnrollment { get; set; }

        public virtual  ICollection<Homework> HomeworkSubmissions { get; set; }
    }
}
