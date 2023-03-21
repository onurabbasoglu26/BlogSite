using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IMessageService : IGenericService<Message>
	{
		List<Message> GetInboxListByWriter(string mail);
	}
}

