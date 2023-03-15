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

        public List<Blog> GetBlogList(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetByTId(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetLastBlog()
        {
            return _blogDal.GetListAll().TakeLast(1).ToList();
        }

        public List<Blog> GetLastBlogsList()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}

