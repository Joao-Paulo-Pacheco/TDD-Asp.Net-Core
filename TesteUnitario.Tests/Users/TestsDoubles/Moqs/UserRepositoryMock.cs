using System;
using System.Collections.Generic;
using System.Text;
using TesteUnitario.Repository;
using TesteUnitario.Tests.Users.TestsDoubles.Spies;

namespace TesteUnitario.Tests.Users.TestsDoubles.Moqs
{
    public class UserRepositoryMock : UserRepositorySpy
    {
        private string _lastUserName;
        private string _lastPassword;
        private int _count;

        public UserRepositoryMock(string lastUserName, string lastPassword, int count)
        {
            _lastUserName = lastUserName;
            _lastPassword = lastPassword;
            _count = count;
        }

        public bool Validate()
        {
            return _lastUserName == GetUserName() &&
                _lastPassword == GetPassword() &&
                _count == GetCount();
        }
    }
}
