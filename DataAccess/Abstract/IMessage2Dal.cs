using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace DataAccess.Abstract
{
	public interface IMessage2Dal : IGenericRepositoryDal<Message2>
	{
        List<Message2> GetListWithMessageByWriter(int id);
    }
}

