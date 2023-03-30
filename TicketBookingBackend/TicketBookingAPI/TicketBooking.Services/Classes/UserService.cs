using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Interfaces;

namespace TicketBooking.Services.Classes
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
