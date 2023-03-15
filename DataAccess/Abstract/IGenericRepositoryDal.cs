using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IGenericRepositoryDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetListAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
    }
}

