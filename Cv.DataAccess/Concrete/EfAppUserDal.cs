using Core.DataAccess.Entity_Framework;
using Cv.DataAccess.Abstract;
using Cv.DataAccess.Concrete.Context;
using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cv.DataAccess.Concrete
{
    public class EfAppUserDal : EfEntityRepositoryBase<AppUser, CvContext>, IAppUserDal
    {
        public bool CheckUser(string userName, string password)
        {
           using(var context=new CvContext())
            {
                var user = context.AppUsers.Where(p => p.UserName == userName && p.Password == password).FirstOrDefault();

                return user != null;
            }
        }

        public AppUser GetByName(string name)
        {
            using(var context=new CvContext())
            {
                return context.AppUsers.Where(p => p.FirstName == name).FirstOrDefault();
            }
        }
    }
}
