using Catalog_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Interfaces
{
    public interface IPerson : IRepository<Person>
    {
        Task<IEnumerable<Person>> Search(string name);
        void UpdatePerson(PersonViewModel p);
        // void Update(PersonViewModel person);
    }
}
