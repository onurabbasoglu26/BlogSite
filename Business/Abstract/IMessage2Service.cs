using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IMessage2Service : IGenericService<Message2>
	{
        List<Message2> GetInboxListByWriter(int id);
    }
}

