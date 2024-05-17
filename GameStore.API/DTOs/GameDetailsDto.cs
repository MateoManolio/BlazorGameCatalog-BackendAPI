namespace GameStore.API.DTOs;

public class GameDetailsDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int GenreId { get; set; }
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}

