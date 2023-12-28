using Bogus;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Users.Fixtures
{
    public class UserFixture
    {
        public static User GetUserValid()
        {
            var faker = new Faker<User>();
            faker.RuleFor(x => x.UserName, r => r.Random.String(5));
            faker.RuleFor(x => x.Password, r => r.Random.String(10));
            return faker;
        }
    }
}
