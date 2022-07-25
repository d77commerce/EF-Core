using System;
using MusicHub.Data.Models.Resurce;

namespace MusicHub.Data.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public DateTime CreateOn { get; set; }

        public EnumResurce.Genre Genre { get; set; }
        public int AlbumId { get; set; }

        public string Album { get; set; }


    }
}
