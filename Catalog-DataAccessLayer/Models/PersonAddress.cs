using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Models
{
    public class PersonAddress
    {

        [Key]
        public int PersonAddressId { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string region { get; set; }

        public string postalCode { get; set; }

        public string details { get; set; }
    }
}
