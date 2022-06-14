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
            throw new NotImplementedException();
        }
        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }
        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
