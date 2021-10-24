using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.WhiteBookDto.Entities;
using WhiteBookBusiness.Abstract;
using WhiteBookDataAccess.Abstract;

namespace WhiteBookBusiness.Concrete
{
    public class MainMenuManager : IMainMenuService
    {
        IMainMenuDal _mainMenuDal;

        public MainMenuManager(IMainMenuDal mainMenuDal)
        {
            _mainMenuDal = mainMenuDal;
        }

        public void Add(MainMenu entity)
        {
            _mainMenuDal.Add(entity);
        }

        public void Delete(MainMenu entity)
        {
            _mainMenuDal.Delete(entity);
        }

        public MainMenu Get(int id)
        {
            return _mainMenuDal.Get(x=>x.Id==id);
        }

        public List<MainMenu> GetAll()
        {
            return _mainMenuDal.GetAll();
        }

        public void Update(MainMenu entity)
        {
            _mainMenuDal.Update(entity);
        }
    }
}
