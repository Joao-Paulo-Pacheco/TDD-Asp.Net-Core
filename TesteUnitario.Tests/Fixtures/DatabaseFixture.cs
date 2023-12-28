using Microsoft.EntityFrameworkCore;
using TesteUnitario.Config;
using TesteUnitario.Users;

namespace TesteUnitario.Tests.Fixtures
{
    public class DatabaseFixture
    {
        private const string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=TesteUnitario;Trusted_Connection=True;";

        private static object _lock = new object();
        private static bool _inicialize;

        public DatabaseFixture()
        {
            lock (_lock)
            {
                if (!_inicialize)
                {
                    using var context = CreateContext();
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    context.AddRange(
                        new User("teste", "senha"),
                        new User("teste2", "senha2"));

                    context.SaveChanges();
                }
            }
        }

        public BancoContext CreateContext()
        {
            return new BancoContext(new DbContextOptionsBuilder<BancoContext>().UseSqlServer(_connectionString).Options);
        }
    }
}
