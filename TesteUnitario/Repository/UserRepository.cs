using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TesteUnitario.Users;

namespace TesteUnitario.Repository
{
    public class UserRepository : IUserRepository
    {
        private DbContext dbContext;

        public UserRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            return dbContext.Set<User>().Where(a => a.UserName == username && a.Password == password).Any();
        }

        public async Task<User> GetUserByUserName(string username)
        {
            return dbContext.Set<User>().Where(a => a.UserName == username).FirstOrDefault();
        }

        public async Task<bool> Add(User user)
        {
            dbContext.Set<User>().Add(user);

            return true;
        }
    }
}
