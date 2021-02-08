using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class ExperienceService:IExperienceService
    {
        private IExperienceDal _experienceDal;
        public ExperienceService(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience experience)
        {
            _experienceDal.Add(experience);
        }

        public void Delete(Experience experience)
        {
            _experienceDal.Delete(experience);
        }

        public Experience GetById(int id)
        {
            return _experienceDal.Get(p => p.Id == id);
        }

        public IList<Experience> GetList()
        {
            return _experienceDal.GetList();
        }

        public void Update(Experience experience)
        {
            _experienceDal.Update(experience);
        }
    }
}
