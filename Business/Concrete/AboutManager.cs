using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About GetByTId(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}

