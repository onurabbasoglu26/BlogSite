using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment GetByTId(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetCommentList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetListAll();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}

