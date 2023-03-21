using System;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfMessage2Dal : GenericRepository<Message2>, IMessage2Dal
	{
	}
}

