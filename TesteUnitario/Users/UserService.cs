using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteUnitario.Repository;

namespace TesteUnitario.Users
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            var existUser = await _userRepository.GetUserByUserName(username);
            if (existUser == null) return false;

            var sucess = await _userRepository.Authenticate(username, password);
            return sucess;
        }
    }
}
