using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv.Entities.Concrete
{
    public class Education:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string GPA { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
