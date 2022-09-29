﻿namespace LMS20.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Duration { get { return (End - Start); } }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();
        public ICollection<Module> Modules { get; set; } = new List<Module>();
        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
