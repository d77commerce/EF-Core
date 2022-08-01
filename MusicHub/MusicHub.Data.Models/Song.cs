using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusicHub.Data.Models.Resurce;

namespace MusicHub.Data.Models
{
    public class Song
    {
        public Song()
        {
            this.SongPreformers = new HashSet<SongPerformer>();
        }

        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public DateTime CreateOn { get; set; }
        [Required]
        public EnumResurce.Genre Genre { get; set; }

        public int AlbumId { get; set; }

        [ForeignKey(nameof(AlbumId))]
        public virtual Album Album { get; set; }

        [Required]
        public int WriterId { get; set; }

        [ForeignKey(nameof(WriterId))]
        public virtual Writer Writer { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<SongPerformer> SongPreformers { get; set; }
    }
}
