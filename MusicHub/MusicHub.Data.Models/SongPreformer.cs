using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Data.Models
{
    public class SongPreformer
    {

        public int SongId { get; set; }

        public int PreformerId { get; set; }

        public Song song { get; set; }

        public Performer preformer { get; set; }


    }
}
