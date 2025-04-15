using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO.CityDTO;

namespace Shipping.MappingProfiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDTO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.status, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.governmentId, opt => opt.MapFrom(src => src.GovernorateId))
                .ForMember(dest => dest.governmentName, opt => opt.MapFrom(src => src.Governorate != null ? src.Governorate.Name : null))
                .ForMember(dest => dest.shippingPrice, opt => opt.MapFrom(src => 0)) // Static value
                .ForMember(dest => dest.pickUpPrice, opt => opt.MapFrom(src => 0)) // Static value
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.status))
                .ForMember(dest => dest.GovernorateId, opt => opt.MapFrom(src => src.governmentId))
                .ForMember(dest => dest.Governorate, opt => opt.Ignore())
                .ForMember(dest => dest.Areas, opt => opt.Ignore())
                .ForMember(dest => dest.Orders, opt => opt.Ignore());
        }
    }
} 