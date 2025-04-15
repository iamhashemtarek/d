using AutoMapper;
using Shipping.Core.DomainModels;
using Shipping.DTO.Employee_DTOs;

namespace Shipping.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmpDTO>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.AppUserId))
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.UserName : null))
                .ForMember(dest => dest.email, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.Email : null))
                .ForMember(dest => dest.phone, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.PhoneNumber : null))
                .ForMember(dest => dest.status, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.branchName, opt => opt.MapFrom(src => string.Empty))
                .ForMember(dest => dest.branchId, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.role, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.password, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.EmployeeCode, opt => opt.MapFrom(src => Guid.NewGuid().ToString().Substring(0, 8)))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.role))
                .ForMember(dest => dest.AppUserId, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.AppUser, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedOrders, opt => opt.Ignore());
        }
    }
} 