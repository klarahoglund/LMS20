using LMS20.Core.Entities;
using LMS20.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS20.Core.ViewModels
{
   public class ModulesViewModel
    {

        public int? CourseId { get; set; }
        //public CreatePartialModuleViewModel createModule { get; set; }
        public IEnumerable<Module>? CourseModules { get; set; }
        public IEnumerable<ModulesPartialViewModel>? ModulesPartialVMs { get; set; } = new List<ModulesPartialViewModel>();
        public Course Course { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        //public Status ModuleStatus { get; set; } 
    }
}
