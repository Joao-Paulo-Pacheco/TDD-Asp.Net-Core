using System.Threading.Tasks;
using TesteUnitario.Users;

namespace TesteUnitario.Repository
{
    public interface IUserRepository
    {
        Task<bool> Authenticate(string username, string password);
        Task<User> GetUserByUserName(string username);
    }
}