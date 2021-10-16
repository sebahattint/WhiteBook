﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Whitebook.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T:class,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
    }
}
