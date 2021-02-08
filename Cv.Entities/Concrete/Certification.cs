using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Entities.Concrete
{
    public class Certification:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
