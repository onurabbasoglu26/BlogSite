using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();

        public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}

