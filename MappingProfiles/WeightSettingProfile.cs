using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO;

namespace Shipping.MappingProfiles
{
    public class WeightSettingProfile : Profile
    {
        public WeightSettingProfile()
        {
            CreateMap<WeightSetting, WeightSettingDTO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.standaredWeight, opt => opt.MapFrom(src => src.BaseWeight))
                .ForMember(dest => dest.addition_Cost, opt => opt.MapFrom(src => src.AdditionalWeightPrice))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.BaseWeight, opt => opt.MapFrom(src => src.standaredWeight))
                .ForMember(dest => dest.AdditionalWeightPrice, opt => opt.MapFrom(src => src.addition_Cost))
                .ForMember(dest => dest.BaseWeightPrice, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.GovernorateId, opt => opt.Ignore())
                .ForMember(dest => dest.Governorate, opt => opt.Ignore());
        }
    }
} 