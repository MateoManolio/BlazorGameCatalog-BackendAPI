using System.ComponentModel.DataAnnotations;

namespace GameStore.API;

public record class CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Required] int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);
