using GameStore.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.API.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
: DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*modelBuilder.Entity<Game>().HasData(
            new Game
            {
                Id = 1,
                Name = "Far cry 3",
                GenreId = 4,
                Genre = new Genre
                {
                    Id = 4,
                    Name = "Adventure",
                },
                Price = 9.99M,
                ReleaseDate = DateOnly.Parse("2021/11/28"),
            }
        );*/
        modelBuilder.Entity<Genre>().HasData(
            new Genre
            {
                Id = 1,
                Name = "Fighting",
            },
        new Genre
        {
            Id = 2,
            Name = "RPG",
        },
        new Genre
        {
            Id = 3,
            Name = "Sports",
        },
        new Genre
        {
            Id = 4,
            Name = "Adventure",
        },
        new Genre
        {
            Id = 5,
            Name = "Kids and Family",
        }
        );
    }
}
