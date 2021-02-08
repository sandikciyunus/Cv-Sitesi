using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class ReferenceService:IReferenceService
    {
        private IReferenceDal _referenceDal;
        public ReferenceService(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public void Add(Reference reference)
        {
            _referenceDal.Add(reference);
        }

        public void Delete(Reference reference)
        {
            _referenceDal.Delete(reference);
        }

        public Reference GetById(int id)
        {
            return _referenceDal.Get(p => p.Id == id);
        }

        public IList<Reference> GetList()
        {
            return _referenceDal.GetList();
        }

        public void Update(Reference reference)
        {
            _referenceDal.Update(reference);
        }
    }
}
