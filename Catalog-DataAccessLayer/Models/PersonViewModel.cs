using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Models
{
    public class PersonViewModel
    {
        public Person person { get; set; }
        public PersonProfile personProfile { get; set; }
    }
}
