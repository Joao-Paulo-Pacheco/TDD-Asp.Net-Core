using Microsoft.EntityFrameworkCore;
using TesteUnitario.Tarefas;
using TesteUnitario.Users;

namespace TesteUnitario.Config
{
    public class BancoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        public BancoContext()
        {

        }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TesteUnitario;Trusted_Connection=True;");
            }
        }
    }
}
