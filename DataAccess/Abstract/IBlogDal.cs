using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IGenericRepositoryDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}

