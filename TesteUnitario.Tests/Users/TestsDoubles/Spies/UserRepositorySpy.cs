using System;
using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.TestsDoubles.Spies
{
    public class UserRepositorySpy : IUserRepository
    {
        private string _lastUserName;
        private string _lastPassword;
        private int _count;
        private bool _result;

        public async Task<bool> Authenticate(string username, string password)
        {
            _count++;
            _lastUserName = username;
            _lastPassword = password;

            return _result;
        }

        public async Task<User> GetUserByUserName(string username)
        {
            return new User();
        }

        public void SetResult(bool result)
        {
            _result = result;
        }

        public string GetUserName() { return _lastUserName; }
        public string GetPassword() { return _lastPassword; }
        public int GetCount() => _count;

        public Task<bool> Add(User user)
        {
            throw new NotImplementedException();
        }
    }
}
