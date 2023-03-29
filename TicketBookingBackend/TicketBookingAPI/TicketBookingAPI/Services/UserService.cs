using TicketBookingAPI.Interface;
using TicketBooking.Models;

namespace TicketBookingAPI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public async Task<int> SaveUser(UserModel userModel)
        {
            var res = await _userRepository.SaveUser(userModel);
            return res;
        }
    }
}
