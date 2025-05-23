using AutoMapper;
using InterwayAPI.Domain.Entities;
using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.AutoMapperProfiles
{
    public class RoleMappingProfile : Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<Role, RoleViewModel>().ReverseMap();
        }
    }
}
