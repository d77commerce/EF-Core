
using SoftJail.Command;
using SoftJail.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.Data.Models
{
   public class Officer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(ValidationConstans.OfficerNameMax)]
        public string FullName { get; set; }
        [Required]
        [Range(typeof(decimal),"0", "79228162514264337593543950335")]
        public decimal Salary { get; set; }
        [Required]
        public Position Position { get; set; }
        [Required]
        public Weapon Weapon { get; set; }




    }
}
