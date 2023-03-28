using AutoMapper;
using TicketBooking.Domain;
using TicketBooking.Models;

namespace Assignment.Api.ServiceCollectionConfigurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<TicketModel, Ticket>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
            CreateMap<CityModel, City>().ReverseMap();
            CreateMap<BusModel, Bus>().ReverseMap();
            CreateMap<TicketModel, Ticket>().ReverseMap();
        }
    }
}