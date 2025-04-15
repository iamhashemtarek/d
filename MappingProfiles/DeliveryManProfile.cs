using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO.DeliveryDTOs;

namespace Shipping.MappingProfiles
{
    public class DeliveryManProfile : Profile
    {
        public DeliveryManProfile()
        {
            CreateMap<DeliveryMan, DeliveryDTO>()
                .ForMember(dest => dest.OrignalIdOnlyInDeliveryTable, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AppUserId))
                .ForMember(dest => dest.DeliveryId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.UserName : null))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.Email : null))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.PhoneNumber : null))
                .ForMember(dest => dest.DeliverName, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.UserName : null))
                .ForMember(dest => dest.DiscountType, opt => opt.MapFrom(src => src.DiscountType))
                .ForMember(dest => dest.CompanyPercentage, opt => opt.MapFrom(src => (int)src.DiscountValue))
                .ForMember(dest => dest.Password, opt => opt.Ignore())
                .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.Government, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.status, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => 0))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DeliveryId ?? src.OrignalIdOnlyInDeliveryTable ?? 0))
                .ForMember(dest => dest.VehicleNumber, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.LicenseNumber, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.DiscountType, opt => opt.MapFrom(src => src.DiscountType))
                .ForMember(dest => dest.DiscountValue, opt => opt.MapFrom(src => src.CompanyPercentage))
                .ForMember(dest => dest.AppUserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AppUser, opt => opt.Ignore())
                .ForMember(dest => dest.AssignedOrders, opt => opt.Ignore());
        }
    }
} 