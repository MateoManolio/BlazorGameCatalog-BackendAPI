using GameStore.API.DTOs;
using GameStore.API.Entities;

namespace GameStore.API.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDto game)
    => new Game
    {
        Name = game.Name,
        GenreId = game.GenreId,
        Price = game.Price,
        ReleaseDate = game.ReleaseDate
    };
    public static Game ToEntity(this UpdateGameDto game, int id)
    => new Game
    {
        Id = id,
        Name = game.Name,
        GenreId = game.GenreId,
        Price = game.Price,
        ReleaseDate = game.ReleaseDate
    };

    public static GameSummaryDto ToGameSummaryDto(this Game game, string genreName)
    => new GameSummaryDto
    {
        Id = game.Id,
        Name = game.Name,
        Genre = genreName,
        Price = game.Price,
        ReleaseDate = game.ReleaseDate,
    };

    public static GameDetailsDto ToGameDetailsDto(this Game game)
    => new GameDetailsDto
    {
        Id = game.Id,
        Name = game.Name,
        GenreId = game.GenreId,
        Price = game.Price,
        ReleaseDate = game.ReleaseDate,
    };
}
