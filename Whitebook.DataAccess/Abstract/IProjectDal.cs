using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.DataAccess.EntityFramework;
using Whitebook.Whitebook.Dto.Entities;

namespace Whitebook.DataAccess.Abstract
{
    public  interface IProjectDal : IEntityRepository<Project>
    {
    }
}
