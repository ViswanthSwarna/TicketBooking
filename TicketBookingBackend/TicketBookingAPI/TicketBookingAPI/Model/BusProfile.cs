using AutoMapper;
using TicketBooking.Domain;

namespace TicketBookingAPI.Model
{
    public class BusProfile : Profile
    {
        public BusProfile()
        {
            CreateMap<BusModel, Bus>()
                .ForMember(dest => dest.BusName, opt => opt.MapFrom(src => src.BusName))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.SourceCity, opt => opt.MapFrom(src => src.SourceCity))
                .ForMember(dest => dest.DestinationCity, opt => opt.MapFrom(src => src.DestinationCity))
                .ForMember(dest => dest.StartDateTime, opt => opt.MapFrom(src => src.StartDateTime))
                .ForMember(dest => dest.EndDateTime, opt => opt.MapFrom(src => src.EndDateTime));
            CreateMap<Bus, BusModel>()
                .ForMember(dest => dest.BusName, opt => opt.MapFrom(src => src.BusName))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.SourceCity, opt => opt.MapFrom(src => src.SourceCity))
                .ForMember(dest => dest.DestinationCity, opt => opt.MapFrom(src => src.DestinationCity))
                .ForMember(dest => dest.StartDateTime, opt => opt.MapFrom(src => src.StartDateTime))
                .ForMember(dest => dest.EndDateTime, opt => opt.MapFrom(src => src.EndDateTime));
        }
    }
}
