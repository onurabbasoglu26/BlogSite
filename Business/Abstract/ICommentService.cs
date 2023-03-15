using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
		List<Comment> GetCommentList(int id);
	}
}

