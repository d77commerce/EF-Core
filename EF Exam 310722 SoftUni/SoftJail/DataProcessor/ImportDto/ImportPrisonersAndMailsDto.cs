using Newtonsoft.Json;
using SoftJail.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportPrisonersAndMailsDto
    {
        [Required]
        [StringLength(ValidationConstans.PrisonerNameMax)]
        [MinLength(ValidationConstans.PrisonerNameMin)]
        [JsonProperty(nameof(FullName))]
        public string FullName { get; set; }
        [Required]
        [JsonProperty(nameof(Nickname))]
        public string Nickname { get; set; }
        [Required]
        [Range(18, 65)]
        [JsonProperty(nameof(Age))]
        public int Age { get; set; }
        [Required]
        [JsonProperty(nameof(IncarcerationDate))]
        public string IncarcerationDate { get; set; }
        [JsonProperty(nameof(ReleaseDate))]
        public string ReleaseDate { get; set; }
        [Range(ValidationConstans.DepartmentMin,ValidationConstans.DepartmentMax)]
        [JsonProperty(nameof(Bail))]
        public decimal? Bail { get; set; }
        [JsonProperty(nameof(CellId))]
        public int? CellId { get; set; }
        [JsonProperty(nameof(Mails))]
        public ImportMailDto[] Mails { get; set; }


    }
}
