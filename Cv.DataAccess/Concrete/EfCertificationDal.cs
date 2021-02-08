using Core.DataAccess.Entity_Framework;
using Cv.DataAccess.Abstract;
using Cv.DataAccess.Concrete.Context;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.DataAccess.Concrete
{
    public class EfCertificationDal:EfEntityRepositoryBase<Certification,CvContext>, ICertificationDal
    {
    }
}
