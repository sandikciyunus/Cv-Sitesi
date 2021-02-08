using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class EducationService:IEducationService
    {
        private IEducationDal _educationDal;
        public EducationService(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void Add(Education education)
        {
            _educationDal.Add(education);
        }

        public void Delete(Education education)
        {
            _educationDal.Delete(education);
        }

        public Education GetById(int id)
        {
            return _educationDal.Get(p => p.Id == id);
        }

        public IList<Education> GetList()
        {
            return _educationDal.GetList();
        }

        public void Update(Education education)
        {
            _educationDal.Update(education);
        }
    }
}
