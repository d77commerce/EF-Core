using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.Data.Models
{
    public class Cell
    {
        [Key]
        public int Id { get; set; }

        
        [Range(typeof(int),"1","1000")]
        public int CellNumber { get; set; }

        public bool HasWindow { get; set; }
    }
}
