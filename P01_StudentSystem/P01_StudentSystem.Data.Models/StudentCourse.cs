using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student{ get; set; }

        public int CourseId { get; set; }
        
        private Course Course { get; set; }
    }
}
