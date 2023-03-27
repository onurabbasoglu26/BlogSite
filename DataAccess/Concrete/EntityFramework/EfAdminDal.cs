using System;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfAdminDal : GenericRepository<Admin>, IAdminDal
	{
		
	}
}

