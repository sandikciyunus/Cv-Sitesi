using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface IInterestService
    {
        IList<Interest> GetList();
        Interest GetById(int id);
        void Add(Interest ınterest);
        void Delete(Interest ınterest);
        void Update(Interest ınterest);
    }
}
