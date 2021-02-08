using Cv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.Models
{
    public class ProjectListViewModel
    {
        public IList<Project> Projects { get; set; }
    }
}
