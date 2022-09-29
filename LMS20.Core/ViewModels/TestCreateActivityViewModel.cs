﻿using LMS20.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS20.Core.ViewModels
{
    public class TestCreateActivityViewModel
    {
        public int Id { get; set; }             // Modulens PK
        public DateTime Start { get; set; }     // Föreslagen aktivitet starttime
        public DateTime End { get; set; }       // Föreslagen aktivitet endtime

        public ICollection<ModuleActivity> ModuleActivities { get; set; } = new List<ModuleActivity>();

    }
}
