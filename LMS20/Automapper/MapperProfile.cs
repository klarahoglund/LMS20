using AutoMapper;
using LMS20.Core.Entities;
using LMS20.Core.ViewModels;

namespace LMS20.Web.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Course, CreatePartialModuleViewModel>().ReverseMap();
            CreateMap<Course, CoursePartialViewModel>();
            CreateMap<Course, ConfirmDeletePartialViewModel>().ReverseMap();

            CreateMap<ApplicationUser, RegistrationViewModel>().ReverseMap();

        }
    }
}
