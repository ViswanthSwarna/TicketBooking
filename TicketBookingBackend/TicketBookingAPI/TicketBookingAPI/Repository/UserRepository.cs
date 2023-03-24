using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBookingAPI.Interface;
using TicketBookingAPI.Model;

namespace TicketBookingAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private TicketManagemetContext _context;
        private IMapper _mapper;
        public UserRepository(TicketManagemetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> SaveUser(UserModel userModel) 
        {
            var user = _mapper.Map<ActiveUser>(userModel);
            _context.Entry(user).State = EntityState.Added;
            var res = await _context.SaveChangesAsync();
            var userId = user.Id;
            return userId;
        }
    }
}
