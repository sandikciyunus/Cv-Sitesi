using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface IExperienceService
    {
        IList<Experience> GetList();
        Experience GetById(int id);
        void Add(Experience experience);
        void Delete(Experience experience);
        void Update(Experience experience);
    }
}
