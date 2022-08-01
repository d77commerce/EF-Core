using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.Data.Models
{
    public class SongPerformer
    {

        public int SongId { get; set; }

        public int PreformerId { get; set; }
        [Required]
        public Song song { get; set; }
        [Required]
        public Performer preformer { get; set; }


    }
}
