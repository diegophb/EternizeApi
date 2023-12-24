

using EternizeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EternizeApi.Context
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinoes { get; set; }

        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

    }
}
