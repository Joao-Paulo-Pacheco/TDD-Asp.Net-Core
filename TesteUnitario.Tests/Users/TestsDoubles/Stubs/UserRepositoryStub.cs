﻿using System;
using System.Threading.Tasks;
using TesteUnitario.Repository;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.TestsDoubles.Stubs
{
    public class UserRepositoryStub : IUserRepository
    {
        public Task<bool> Add(User user)
        {
            throw new NotImplementedException();
        }

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
