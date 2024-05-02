using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contacts.Common
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        bool Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
