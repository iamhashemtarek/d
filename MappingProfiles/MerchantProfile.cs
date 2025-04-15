using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO.MerchantDTOs;

namespace Shipping.MappingProfiles
{
    public class MerchantProfile : Profile
    {
        public MerchantProfile()
        {
            CreateMap<Merchant, MerchantDTO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.AppUserId))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.UserName : null))
                .ForMember(dest => dest.email, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.Email : null))
                .ForMember(dest => dest.phone, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.PhoneNumber : null))
                .ForMember(dest => dest.status, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.pickUpSpecialCost, opt => opt.MapFrom(src => (int)src.PickupCost))
                .ForMember(dest => dest.refusedOrderPercent, opt => opt.MapFrom(src => (int)src.RejectedOrdersShippingRatio))
                .ForMember(dest => dest.password, opt => opt.Ignore())
                .ForMember(dest => dest.government, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.city, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.role, opt => opt.MapFrom(src => "التجار"))
                .ForMember(dest => dest.branchName, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.SpecialCitiesPrices, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.StoreName, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.PickupCost, opt => opt.MapFrom(src => src.pickUpSpecialCost))
                .ForMember(dest => dest.RejectedOrdersShippingRatio, opt => opt.MapFrom(src => src.refusedOrderPercent))
                .ForMember(dest => dest.AppUserId, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.AppUser, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedOrders, opt => opt.Ignore());
        }
    }
} 