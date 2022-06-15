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
        public IEnumerable<Person> GetAllPerson()
        {
            try
            {
                return _person.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task DeletePerson(int id)
        {

            try
            {
                var DataList = _person.GetById(id);
                _person.Delete(DataList);

            }
            catch (Exception)
            {
                throw;
            }

        }
        public Person GetPersonById(int id)
        {
            return _person.GetById(id);
        }

        public async Task UpdatePerson(Person p)
        {
            try
            {

                _person.Update(p);


            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IEnumerable<Person>> SearchByName(string name)
        {
            try
            {
                return await _person.Search(name);
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }
}
