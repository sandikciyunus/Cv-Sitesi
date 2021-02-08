using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Abstract
{
    public interface IAppUserService
    {
        IList<AppUser> GetList();
        AppUser GetByName(string name);
        bool CheckUser(string userName, string password);

        void Update(AppUser appUser);
    }
}
