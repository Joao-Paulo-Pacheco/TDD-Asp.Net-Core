using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.TestsDoubles.Dummys
{
    public class UserRepositoryDummy : IUserRepository
    {
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
