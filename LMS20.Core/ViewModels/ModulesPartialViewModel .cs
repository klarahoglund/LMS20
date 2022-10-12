using LMS20.Core.Entities;
using LMS20.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS20.Core.ViewModels
{

   public class ModulesPartialViewModel
    {

        public int? CourseId { get; set; }
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string CourseName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public Course Course { get; set; }
        public Status ModuleStatus { get; set; } 
    }
}
