using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface IEducationService
    {
        IList<Education> GetList();
        Education GetById(int id);
        void Add(Education education);
        void Delete(Education education);
        void Update(Education education);
    }
}
