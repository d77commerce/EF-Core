using System;
using System.ComponentModel.DataAnnotations;
using MusicHub.Data.Models.Resurce;

namespace MusicHub.Data.Models
{
    public class Song
    {

        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Duration { get; set; }
        [Required]
        public DateTime CreateOn { get; set; }
        [Required]
        public EnumResurce.Genre Genre { get; set; }

        public int AlbumId { get; set; }

        public string Album { get; set; }
        [Required]
        public int WriterId { get; set; }

        public string Writer { get; set; }
        [Required]
        public decimal Price { get; set; }


    }
}
