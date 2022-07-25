using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicHub.Data.Models
{
    public class Album
    {
        private decimal _price;
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
                var collection = new ICollection<Song>();
            } 
        }
    }
}