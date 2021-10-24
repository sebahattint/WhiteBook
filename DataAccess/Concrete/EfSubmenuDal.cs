using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.WhiteBookDto.Entities;
using WhiteBookDataAccess.Abstract;
using WhiteBookDataAccess.Context;
using WhiteBookDataAccess.EntityFremawoek;

namespace WhiteBookDataAccess.Concrete
{
    public class EfSubmenuDal:EfEntityRepositoryBase<Submenu,WhiteBookContext>,ISubmenuDal
    {
    }
}
