using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.WhiteBookDto.Entities;
using WhiteBookBusiness.Abstract;
using WhiteBookDataAccess.Abstract;

namespace WhiteBookBusiness.Concrete
{
    public class SubMenuManager : ISubMenuService
    {
        ISubmenuDal _submenuDal;

        public SubMenuManager(ISubmenuDal submenuDal)
        {
            _submenuDal = submenuDal;
        }

        public void Add(Submenu entity)
        {
            _submenuDal.Add(entity);
        }

        public void Delete(Submenu entity)
        {
            _submenuDal.Delete(entity);
        }
        public Submenu Get(int id)
        {
            return _submenuDal.Get(x=>x.Id==id);
        }

        public List<Submenu> GetAll()
        {
            return _submenuDal.GetAll();
        }

        public void Update(Submenu entity)
        {
            _submenuDal.Update(entity);
        }
    }
}
