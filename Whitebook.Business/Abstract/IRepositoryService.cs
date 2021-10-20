using System;
using System.Collections.Generic;
using System.Text;

namespace Whitebook.Business.Abstract
{
    public interface IRepositoryService<T>
    {
        List<T> GetAll();
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
