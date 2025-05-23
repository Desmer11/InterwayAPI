using AutoMapper;
using InterwayAPI.Domain.Entities;
using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.AutoMapperProfiles
{
    public class InvoiceMappingProfile : Profile
    {
        public InvoiceMappingProfile()
        {
            CreateMap<Invoice, InvoiceViewModel>()
                .ForMember(x => x.InvoiceStatus, opt => opt.Ignore())
                .ForMember(x => x.InvoiceStatus, opt => opt.MapFrom(y => y.InvoiceStatusId))
                .ReverseMap()
                .ForMember(x => x.InvoiceStatus, opt => opt.Ignore())
                .ForMember(x => x.InvoiceStatusId, opt => opt.MapFrom(y => y.InvoiceStatus));

            CreateMap<InvoiceLineItem, InvoiceLineItemViewModel>().ReverseMap();

            CreateMap<PagedResultModel<Invoice>, PagedResultViewModel<InvoiceViewModel>>().ReverseMap();

        }
    }
}
