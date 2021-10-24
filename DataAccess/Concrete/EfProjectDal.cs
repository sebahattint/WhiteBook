using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.WhiteBookDto.Entities;
using WhiteBookDataAccess.Abstract;
using WhiteBookDataAccess.Context;
using WhiteBookDataAccess.EntityFremawoek;

namespace WhiteBookDataAccess.Concrete
{
    public class EfProjectDal:EfEntityRepositoryBase<Project,WhiteBookContext>,IProjectDal
    {
    }
}
