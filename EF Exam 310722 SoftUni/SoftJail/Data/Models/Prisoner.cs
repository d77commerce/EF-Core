using System;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.Data.Models
{
    public class Prisoner
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime IncarcerationDate { get; set; }

        public DateTime? ReleaseDate { get; set; }
        [Range(typeof(decimal),"0", "79228162514264337593543950335")]
        public decimal? Bail { get; set; }



    }
}