using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.WhiteBookDto.Entities;
using WhiteBookBusiness.Abstract;
using WhiteBookDataAccess.Abstract;

namespace WhiteBookBusiness.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content entity)
        {
            _contentDal.Add(entity);
        }

        public void Delete(Content entity)
        {
            _contentDal.Delete(entity);
        }

        public Content Get(int id)
        {
            return _contentDal.Get(x=>x.Id==id);
        }

        public List<Content> GetAll()
        {
            return _contentDal.GetAll();
        }

        public void Update(Content entity)
        {
            _contentDal.Update(entity);
        }
    }
}
