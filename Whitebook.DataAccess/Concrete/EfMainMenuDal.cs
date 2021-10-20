using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.DataAccess.Abstract;
using Whitebook.DataAccess.Context;
using Whitebook.DataAccess.EntityFramework;
using Whitebook.Whitebook.Dto.Entities;

namespace Whitebook.DataAccess.Concrete
{
    public class EfMainMenuDal :EfEntityRepositoryBase<MainMenu,WhiteBookContext>,IMainMenuDal
    {
    }
}
