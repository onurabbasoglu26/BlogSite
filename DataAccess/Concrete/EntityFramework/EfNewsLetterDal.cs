using System;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfNewsLetterDal : GenericRepository<NewsLetter>, INewsLetterDal
    {
        public EfNewsLetterDal()
        {
        }
    }
}

