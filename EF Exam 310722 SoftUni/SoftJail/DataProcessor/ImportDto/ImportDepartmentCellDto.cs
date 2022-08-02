
using Newtonsoft.Json;
using SoftJail.Command;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportDepartmentCellDto
    {
        [Required]
        [MaxLength(ValidationConstans.DepartmentMax)]
        [MinLength(ValidationConstans.DepartmentMin)]
        [JsonProperty(nameof(Name))]
        public string Name { get; set; }

        public ImportCellDto[] Cells { get; set; }
    }
}
