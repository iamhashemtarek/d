using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO.BranchDTOs;

namespace Shipping.MappingProfiles
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<Branch, BranchDTO>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => 0)) // Static value
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => string.Empty)) // Static value
                .ReverseMap()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.Date ?? DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => string.Empty)) // Static value
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => string.Empty)) // Static value
                .ForMember(dest => dest.UserBranches, opt => opt.Ignore())
                .ForMember(dest => dest.Orders, opt => opt.Ignore());
        }
    }
} 