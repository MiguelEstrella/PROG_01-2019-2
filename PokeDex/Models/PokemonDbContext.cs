using Microsoft.EntityFrameworkCore;

namespace PokeDex.Models
{
    public class PokemonDbContext : DbContext
    {
            public DbSet<Pokemon> Pokemones { get; set;}

            public PokemonDbContext(DbContextOptions<PokemonDbContext> o) : base(o)
            {
                   
            }
    }
}