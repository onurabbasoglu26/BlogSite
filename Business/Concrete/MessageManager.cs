using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class MessageManager : IMessageService
	{
		IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByTId(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetInboxListByWriter(string mail)
        {
            return _messageDal.GetListAll(x => x.Receiver == mail);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}

