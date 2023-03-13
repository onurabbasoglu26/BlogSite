using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface ICommentService
	{
		void AddComment(Comment comment);
		List<Comment> GetCommentList(int id);
	}
}

