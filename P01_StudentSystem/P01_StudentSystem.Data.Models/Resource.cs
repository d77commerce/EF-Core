using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        public int ResorceId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public enum ContentType { Video, Presentation, Document, Other }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public int  CourseId { get; set; }
    }
}
