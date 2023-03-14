using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetter;

        public NewsLetterManager(INewsLetterDal newsLetter)
        {
            _newsLetter = newsLetter;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetter.Insert(newsLetter);
        }
    }
}

