using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Domain;

namespace TicketBooking.Repository.Classes
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

        public async Task<string> SaveUser(UserModel userModel) 
        {
            var user = _mapper.Map<User>(userModel);
            _context.Entry(user).State = EntityState.Added;
            var res = await _context.SaveChangesAsync();
            var userId = user.Id;
            return userId;
        }
    }
}
