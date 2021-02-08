using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Entities.Concrete
{
    public class Reference:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Unvan { get; set; }
        public string PhoneNumber { get; set; }
    }
}
