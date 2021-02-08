using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface IReferenceService
    {
        IList<Reference> GetList();
        Reference GetById(int id);
        void Add(Reference reference);
        void Delete(Reference reference);
        void Update(Reference reference);
    }
}
