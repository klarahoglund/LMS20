using LMS20.Core.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LMS20.Core.ViewModels
{
    public class EditCourseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Namn är obligatoriskt")]
        [Display(Name = "Krusens namn")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Beskrivning är obligatoriskt")]
        [Display(Name = "Beskrivning")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Starttid är obligatoriskt")]
        [Remote("ValidateCourseStart", "Courses")]
        [ValidateCourseDate]
        [Display(Name = "Starttid")]
        [DataType(DataType.Date)]
        public DateTime Start { get; set; } = DateTime.Now + TimeSpan.FromDays(1);

        [Required(ErrorMessage = "Slutttid är obligatoriskt")]
        [Remote("ValidateCourseEnd", "Courses", AdditionalFields = "Start")]
        [ValidateCourseDate]
        [Display(Name = "Sluttid")]
        [DataType(DataType.Date)]
        public DateTime End { get; set; } = DateTime.Now + TimeSpan.FromDays(7);
    }
}