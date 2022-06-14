using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Models
{
    public class PersonProfile 
    {
        [Key]
        public int ProfileID { get; set; }

        [Required(ErrorMessage = "Please provide Gender")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Please provide Mobile Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Please provide Mobile Number")]
        public int Age { get; set; }
        
        public string NationalId { get; set; }

        [Required(ErrorMessage = "Please provide Educational Information")]
        public string Educational_Information { get; set; }
        public int PersonID { get; set; }
        public Person person { get; set; }
    }
}
