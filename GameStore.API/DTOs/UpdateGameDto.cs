using System.ComponentModel.DataAnnotations;

namespace GameStore.API.DTOs;

public record class UpdateGameDto(
    [Required][StringLength(50)] string Name,
    [Required] int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);