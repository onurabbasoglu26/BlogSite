using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IBlogService
	{
		void AddBlog(Blog blog);
		void UpdateBlog(Blog blog);
		void DeleteBlog(Blog blog);
		List<Blog> GetBlogList();
		List<Blog> GetLastBlogsList();
		List<Blog> GetLastBlog();
		List<Blog> GetBlogList(int id);
		Blog GetByBlogId(int id);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListByWriter(int id);
	}
}

