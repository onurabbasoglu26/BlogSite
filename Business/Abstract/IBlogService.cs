using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetLastBlogsList();
        List<Blog> GetLastBlog();
        List<Blog> GetBlogList(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
    }
}

