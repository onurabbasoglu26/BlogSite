using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetCategoryList()
        {
            return _categoryDal.GetList();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

