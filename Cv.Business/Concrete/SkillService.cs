using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class SkillService:ISkillService
    {
        private ISkillDal _skillDal;
        public SkillService(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill skill)
        {
            _skillDal.Add(skill);
        }

        public void Delete(Skill skill)
        {
            _skillDal.Delete(skill);
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(p => p.Id == id);
        }

        public IList<Skill> GetList()
        {
            return _skillDal.GetList();
        }

        public void Update(Skill skill)
        {
            _skillDal.Update(skill);
        }
    }
}
