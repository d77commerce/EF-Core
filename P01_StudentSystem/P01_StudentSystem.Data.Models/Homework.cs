using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public enum ContentType
        {
            Application,
            Pdf,
            Zip
        }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }

        public int  CourseId { get; set; }

    }
}
