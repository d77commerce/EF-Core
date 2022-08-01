using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MusicHub.Data.Models
{
    public class Album
    {
        private decimal _price;

        public Album()
        {
          this.Songs = new HashSet<Song>();
        }
        public int Id { get; set; }

        [StringLength(40)]
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseData { get; set; }


        public decimal Price
        {
            
            get => _price;
            set
            {
                _price = Songs.Sum(s => s.Price);
            } 
        }

        public int ProducerId { get; set; }

        [ForeignKey(nameof(ProducerId))]
        public virtual Producer Producer { get; set; }

        public virtual ICollection<Song> Songs{ get; set; }
    }
}