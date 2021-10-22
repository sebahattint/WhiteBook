using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Business.Abstract;
using Whitebook.Whitebook.Dto.Entities;
using WhiteBookDataAccess.Abstract;

namespace Whitebook.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Add(Project entity)
        {
            _projectDal.Add(entity);
        }

        public void Delete(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public Project Get(int id)
        {
            return _projectDal.Get(x=>x.Id==id);
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public void Update(Project entity)
        {
            _projectDal.Update(entity);
        }
    }
}
