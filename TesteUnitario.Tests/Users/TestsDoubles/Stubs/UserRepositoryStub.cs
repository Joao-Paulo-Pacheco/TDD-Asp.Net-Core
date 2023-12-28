using System;
using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.TestsDoubles.Stubs
{
    public class UserRepositoryStub : IUserRepository
    {
        public async Task<bool> Authenticate(string username, string password)
        {
            return false;
        }

        public async Task<User> GetUserByUserName(string username)
        {
            return new User();
        }
    }
}
