using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    interface IRepository<T>
    {
        public List<T> GetAll();
        public T GetByID(int ID);
        public void Add(T entity);
        public void Update(T entity);
        public void Delate(T entity);

    }
}
