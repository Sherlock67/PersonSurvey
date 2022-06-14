using Catalog_DataAccessLayer.Interfaces;
using Catalog_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_BusinessLayer.Services
{
    public class PersonService 
    {
        public readonly IPerson _person;
        public PersonService(IPerson person)
        {
           _person = person;
        }
        public async Task<Person> CreatePerson(Person person)
        {
            return await _person.Create(person);
        }
    }
}
