using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Entities.Concrete
{
    public class Project:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
