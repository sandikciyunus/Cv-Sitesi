using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface IProjectService
    {
        IList<Project> GetList();
        Project GetById(int id);
        void Add(Project project);
        void Delete(Project project);
        void Update(Project project);
    }
}
