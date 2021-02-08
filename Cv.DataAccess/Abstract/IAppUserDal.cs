using Core.DataAcces;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.DataAccess.Abstract
{
    public interface IAppUserDal:IEntityRepository<AppUser>
    {
        AppUser GetByName(string name);
        bool CheckUser(string userName, string password);
    }
}
