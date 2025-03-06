using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.DTOs;

public record class CreateGameDTO(
    [Required][StringLength(50)] string Name, 
    [Required][StringLength(20)] string Genre, 
    [Range(1, 100)] decimal price,
    DateOnly ReleaseDate);
