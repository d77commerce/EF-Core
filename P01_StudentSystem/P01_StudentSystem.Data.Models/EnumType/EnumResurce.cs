using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data.Models.EnumType
{
    public class EnumResurce
    {
        public enum ResurceType
        {
            Video, 
            Presentation,
            Document, 
            Other

        }
        public enum ContentType
        {
            Application,
            Pdf,
            Zip
        }
    }
}
