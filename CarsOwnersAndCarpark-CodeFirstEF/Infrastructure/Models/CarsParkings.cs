using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class CarsParkings
    {
        [Key, Column(Order = 1)]
        public int CarId { get; set; }
        [Key, Column(Order = 2)]
        public int ParkingId { get; set; }
        public Car? Car { get; set; }


        public Parking? Parking { get; set; }
    }
}
