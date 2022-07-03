using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class Parking
    {
        [Key]
       public int Id { get; set; }
        [StringLength(50)]
       public string Name { get; set; }
        [StringLength(100)]
       public string Address { get; set; }
       public  int Capacity { get; set; }
      public ICollection<CarsParkings> CarsParkings { get; set; }
    }
}
