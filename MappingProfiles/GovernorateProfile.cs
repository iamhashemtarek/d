using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO.GovernmentDTO;

namespace Shipping.MappingProfiles
{
    public class GovernorateProfile : Profile
    {
        public GovernorateProfile()
        {
            CreateMap<Governorate, GovernmentDTO>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsActive))
                .ReverseMap()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.Cities, opt => opt.Ignore())
                .ForMember(dest => dest.WeightSettings, opt => opt.Ignore())
                .ForMember(dest => dest.Orders, opt => opt.Ignore());
        }
    }
} 