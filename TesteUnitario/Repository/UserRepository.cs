using Microsoft.EntityFrameworkCore;
using System;
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

        public Task<bool> Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByUserName(string username)
        {
            throw new NotImplementedException();
        }
    }
}
