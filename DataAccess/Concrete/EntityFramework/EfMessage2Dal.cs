using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMessage2Dal : GenericRepository<Message2>, IMessage2Dal
    {
        Context c = new Context();

        public List<Message2> GetListWithMessageByWriter(int id)
        {
            return c.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverId == id).ToList();
        }
    }
}

