using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
   public class ImportPresonerMail
    {
        [Required]
        public string Description { get; set; }

        public string Sender { get; set; }

        public string Address { get; set; }
    }
}
