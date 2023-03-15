using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByTId(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetListAll();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}

