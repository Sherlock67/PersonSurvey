using Catalog_DataAccessLayer.Data;
using Catalog_DataAccessLayer.Interfaces;
using Catalog_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Repository
{
    public class PersonRepository : IPerson
    {
        public readonly ApplicationDbContext _db;
        public PersonRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Person> Create(Person entity)
        {
            var obj = await _db.person.AddAsync(entity);
            _db.SaveChanges();
            return obj.Entity;
        }
        public void Delete(Person entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
            
        }
        public IEnumerable<Person> GetAll()
        {
            try
            {
                return _db.person.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public Person GetById(int id)
        {
          
             return _db.person.Where(x => x.PersonID == id).SingleOrDefault();
           
          
        }

        public async Task<IEnumerable<Person>> Search(string name)
        {
            IQueryable<Person> query = _db.person;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e =>e.FirstName.Contains(name) || e.LastName.Contains(name));
            }
            return query.ToList();
        }

        public void Update(Person entity)
        {
            _db.person.Update(entity);
            _db.SaveChanges();
        }

        public void UpdatePerson(PersonViewModel p)
        {
            _db.person.Update(p.person);
            _db.SaveChanges();
            //throw new NotImplementedException();
        }

        //public void Update(PersonViewModel p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
