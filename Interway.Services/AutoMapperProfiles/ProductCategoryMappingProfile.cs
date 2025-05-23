using AutoMapper;
using InterwayAPI.Domain.Entities;
using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.AutoMapperProfiles
{
    public class ProductCategoryMappingProfile : Profile
    {
        public ProductCategoryMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>()
                .ForMember(x => x.ProductCategoryStatus, opt => opt.Ignore())
                .ForMember(x => x.ProductCategoryStatus, opt => opt.MapFrom(s => s.ProductCategoryStatusId))
                .ReverseMap()
                .ForMember(x => x.ProductCategoryStatus, opt => opt.Ignore())
                .ForMember(x => x.ProductCategoryStatusId, opt => opt.MapFrom(x => x.ProductCategoryStatus));

            CreateMap<PagedResultModel<ProductCategory>, PagedResultViewModel<ProductCategoryViewModel>>();
        }
    }
}
