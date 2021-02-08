using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class ProjectService:IProjectService
    {
        private IProjectDal _projectDal;
        public ProjectService(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Add(Project project)
        {
            _projectDal.Add(project);
        }

        public void Delete(Project project)
        {
            _projectDal.Delete(project);
        }

        public Project GetById(int id)
        {
            return _projectDal.Get(p => p.Id == id);
        }

        public IList<Project> GetList()
        {
            return _projectDal.GetList();
        }

        public void Update(Project project)
        {
            _projectDal.Update(project);
        }
    }
}
