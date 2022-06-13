using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Please write your name")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please write your email address")]
        public string Email_Address { get; set; } 
        
        [Required(ErrorMessage = "Please provide your password")]
       
        public string Password { get; set; }
        [Required(ErrorMessage = "Please provide Gender")]
        public string Gender { get; set; }

        public string Mobile { get; set; }

        public string NationalId { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Educational_Information { get; set; }

    }
}
