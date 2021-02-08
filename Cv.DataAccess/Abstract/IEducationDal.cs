using Core.DataAcces;
using Cv.DataAccess.Concrete.Context;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.DataAccess.Abstract
{
    public interface IEducationDal:IEntityRepository<Education>
    {
    }
}
