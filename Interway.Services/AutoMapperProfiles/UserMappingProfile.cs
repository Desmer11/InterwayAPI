using AutoMapper;
using InterwayAPI.Domain.Entities;
using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.AutoMapperProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<User, RegisterUserViewModel>().ReverseMap();
        }
    }
}
