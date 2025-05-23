using AutoMapper;
using InterwayAPI.Domain.Entities;
using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.AutoMapperProfiles
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(x => x.ProductStatus, opt => opt.Ignore())
                .ForMember(x => x.Info, opt => opt.MapFrom(s => $"{s.Id.ToString("000")} - {s.Name} ({s.ProductCategory.Name})"))
                .ForMember(x => x.ProductStatus, opt => opt.MapFrom(s => s.ProductStatusId))
                .ReverseMap()
                .ForMember(x => x.ProductStatus, opt => opt.Ignore())
                .ForMember(x => x.ProductStatusId, opt => opt.MapFrom(x => x.ProductStatus));

            CreateMap<PagedResultModel<Product>, PagedResultViewModel<ProductViewModel>>().ReverseMap();
        }
    }
}
