using AutoMapper;
using TicketBookingDomain;

namespace TicketBookingAPI.Model
{
    public class CityDetailsProfile : Profile
    {
        public CityDetailsProfile() 
        {
            CreateMap<CityDetailsModel, CityDetails>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<CityDetails, CityDetailsModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
