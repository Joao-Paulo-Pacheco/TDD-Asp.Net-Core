using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.Fakes
{
    public class UserRepositoryFake : IUserRepository
    {
        public Task<bool> Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            return (username.Equals("user") && password.Equals("12345"));
        }

        public async Task<User> GetUserByUserName(string username)
        {
            return new User();
        }
    }
}
