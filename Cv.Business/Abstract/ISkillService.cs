using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface ISkillService
    {
        IList<Skill> GetList();
        Skill GetById(int id);
        void Add(Skill skill);
        void Delete(Skill skill);
        void Update(Skill skill);
    }
}
