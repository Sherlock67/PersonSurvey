using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Interfaces
{
    public interface IRepository<T>
    {

        public Task<T> Create(T entity);

        public void Update(T entity);

        public IEnumerable<T> GetAll();

        public T GetById(int id);

        public void Delete(T entity);

    }
}
