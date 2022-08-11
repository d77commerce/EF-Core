using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
   public class ImportMailDto

    {
        [Required]
        [JsonProperty(nameof(Description))]
        public string Description { get; set; }
        [Required]
        [JsonProperty(nameof(Sender))]
        public string Sender { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]+\s[A-Z][a-z]+\s[A-Z][a-z]*\sstr.")]
        public string Address { get; set; }
    }
}
