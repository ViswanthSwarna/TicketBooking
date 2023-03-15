using AutoMapper;
using TicketBooking.Domain;

namespace TicketBookingAPI.Model
{
    public class CityProfile : Profile
    {
        public CityProfile() 
        {
            CreateMap<CityModel, City>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<City, CityModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
