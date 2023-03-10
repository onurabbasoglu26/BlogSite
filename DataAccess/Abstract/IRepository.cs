using System;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetById(int id);
    }
}

