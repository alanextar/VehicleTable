using AutoMapper;
using VehicleTable;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Vehicle, VehicleDto>().ForMember(dest => dest.CDescription, opt => opt.MapFrom(src =>
                src.CDescription != null && src.CDescription.Length > 100 ? src.CDescription.Substring(0, 100) + "..." : src.CDescription));
    }
}