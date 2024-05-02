using DataAccessLayer.Contacts.Common;
using DataAccessLayer.Data;
using DataAccessLayer.IRepositories.Memorandum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Common
{
    public class Repository<T>:IRepository<T> where T : class
    {
        //public readonly MemorandumDbContext _context;
        public DbSet<T> table = null;
        public Repository(MemorandumDbContext _context) 
        {
            //_context = context;
            table = _context.Set<T>();
        }

        public T Add(T entity)
        {
            var result = table.Add(entity);
            return result.Entity;
        }

        public bool Delete(int id)
        {
            var result = table.Find(id);
            if (result == null)
            {
                throw new Exception("Data not found");
            }
            else
            {
                table.Remove(result);
                return true;
            }
        }

        public List<T> GetAll()
        {
            var result = table.ToList();
            return result;
        }

        public T GetById(int id)
        {
            var result = table.Find(id);
            return result;
        }

        public T Update(T entity)
        {
            var result = table.Update(entity);
            return result.Entity;
        }
    }
}
