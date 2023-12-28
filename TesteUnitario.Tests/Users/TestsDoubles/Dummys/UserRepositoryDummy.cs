using System;
using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.TestsDoubles.Dummys
{
    public class UserRepositoryDummy : IUserRepository
    {
        public Task<bool> Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByUserName(string username)
        {
            return null;
        }
    }
}
