using Newtonsoft.Json;
using SoftJail.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportPrisonersMails
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
        public int Age { get; set; }
        [Required]
        public string IncarcerationDate { get; set; }

        public string ReleaseDate { get; set; }
        [Range(ValidationConstans.DepartmentMin,ValidationConstans.DepartmentMax)]
        public decimal? Bail { get; set; }

        public int? CellId { get; set; }

    }
}
