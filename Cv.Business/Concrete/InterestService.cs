using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class InterestService:IInterestService
    {
        private IInterestDal _interestdal;
        public InterestService(IInterestDal interestDal)
        {
            _interestdal = interestDal;
        }

        public void Add(Interest ınterest)
        {
            _interestdal.Add(ınterest);
        }

        public void Delete(Interest ınterest)
        {
            _interestdal.Delete(ınterest);
        }

        public Interest GetById(int id)
        {
            return _interestdal.Get(p => p.Id == id);
        }

        public IList<Interest> GetList()
        {
            return _interestdal.GetList();
        }

        public void Update(Interest ınterest)
        {
            _interestdal.Update(ınterest);
        }
    }
}
