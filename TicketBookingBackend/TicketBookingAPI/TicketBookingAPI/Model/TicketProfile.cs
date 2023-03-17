using AutoMapper;
using TicketBooking.Domain;

namespace TicketBookingAPI.Model
{
    public class TicketProfile : Profile
    {
        public TicketProfile() 
        {
            CreateMap<TicketModel, Ticket>()
                .ForMember(dest => dest.Fare, opt => opt.MapFrom(src => src.Fare))
               .ForMember(dest => dest.IsPaymentDone, opt => opt.MapFrom(src => src.IsPaymentDone))
                .ForMember(dest => dest.BusId, opt => opt.MapFrom(src => src.BusId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.Bus, opt => opt.MapFrom(src => src.Bus));
            CreateMap<Ticket, TicketModel>()
                .ForMember(dest => dest.Fare, opt => opt.MapFrom(src => src.Fare))
                .ForMember(dest => dest.IsPaymentDone, opt => opt.MapFrom(src => src.IsPaymentDone))
                .ForMember(dest => dest.BusId, opt => opt.MapFrom(src => src.BusId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.Bus, opt => opt.MapFrom(src => src.Bus))
                ;
        }
    }
}
