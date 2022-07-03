using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class CarsParkings
    {
        public int CarId { get; set; }
        public Car Car  { get; set; }

        public int ParkingId { get; set; }
        public Parking Parking { get; set; }
    }
}
