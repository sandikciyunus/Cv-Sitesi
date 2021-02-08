using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class CertificationService: ICertificationService
    {
        private ICertificationDal _certificationDal;
        public CertificationService(ICertificationDal certificationDal)
        {
            _certificationDal = certificationDal;
        }

        public void Add(Certification certification)
        {
            _certificationDal.Add(certification);
        }

        public void Delete(Certification certification)
        {
            _certificationDal.Delete(certification);
        }

        public Certification GetById(int id)
        {
            return _certificationDal.Get(p => p.Id == id);
        }

        public IList<Certification> GetList()
        {
            return _certificationDal.GetList();
        }

        public void Update(Certification certification)
        {
            _certificationDal.Update(certification);
        }
    }
}
