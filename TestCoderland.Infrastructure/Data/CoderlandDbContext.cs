using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestCoderland.Core.Entities;

namespace TestCoderland.Infrastructure.Data
{
    public class CoderlandDbContext: DbContext
    {
        public DbSet<MarcaAuto> MarcasAuto { get; set; }

        private readonly IConfiguration Config;

        public CoderlandDbContext(DbContextOptions<CoderlandDbContext> options, IConfiguration config) : base(options)
        {
            Config = config;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define la tabla
            modelBuilder.Entity<MarcaAuto>().ToTable("marcas_de_autos");

            // Agrega datos iniciales usando HasData
            modelBuilder.Entity<MarcaAuto>().HasData(
                new MarcaAuto { Id = 1, Nombre = "Toyota", PaisOrigen = "Japón" },
                new MarcaAuto { Id = 2, Nombre = "Ford", PaisOrigen = "Estados Unidos" },
                new MarcaAuto { Id = 3, Nombre = "Renault", PaisOrigen = "Francia" },
                new MarcaAuto { Id = 4, Nombre = "Kia", PaisOrigen = "Corea del Sur" },
                new MarcaAuto { Id = 5, Nombre = "Chevrolet", PaisOrigen = "Estados Unidos" }
            );
        }

    }
}
