using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Business.Concrete
{
    public class AppUserService : IAppUserService
    {
        private IAppUserDal _appUserDal;
        public AppUserService(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }
        public bool CheckUser(string userName, string password)
        {
            return _appUserDal.CheckUser(userName, password);
        }

        public AppUser GetByName(string name)
        {
            return _appUserDal.GetByName(name);
        }

        public IList<AppUser> GetList()
        {
            return _appUserDal.GetList();
        }

        public void Update(AppUser appUser)
        {
            _appUserDal.Update(appUser);
        }
    }
}
