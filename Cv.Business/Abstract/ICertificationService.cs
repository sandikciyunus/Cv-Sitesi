using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface ICertificationService
    {
        IList<Certification> GetList();
        Certification GetById(int id);

        void Add(Certification certification);
        void Delete(Certification certification);
        void Update(Certification certification);
    }
}
