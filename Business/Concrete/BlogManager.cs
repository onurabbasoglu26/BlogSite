using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogList()
        {
            return _blogDal.GetList();
        }

        public List<Blog> GetBlogList(int id)
        {
            return _blogDal.GetList(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetList(x => x.WriterId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetByBlogId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetLastBlog()
        {
            return _blogDal.GetList().TakeLast(1).ToList();
        }

        public List<Blog> GetLastBlogsList()
        {
            return _blogDal.GetList().TakeLast(3).ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}

