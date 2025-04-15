using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO;

namespace Shipping.MappingProfiles
{
    public class UserBranchProfile : Profile
    {
        public UserBranchProfile()
        {
            CreateMap<UserBranch, UserBranchDTO>()
                .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch != null ? src.Branch.Name : null))
                .ReverseMap()
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.Branch, opt => opt.Ignore());
        }
    }
} 