using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> GetList();
        T GetByTId(int id);
    }
}

