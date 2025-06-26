using System.ComponentModel.DataAnnotations;

namespace FishShop.Features.Fishes.CreateFish;

public record CreateFishDto(
    [Required][StringLength(70)]string Name,
    Guid FishTypeId,
    [Required][StringLength(70)]string Habitat,
    decimal MaxSizeInInches,
    [Required][StringLength(1000)]string Description,
    decimal Price,
    bool KoiFish
);

public record FishDetailsDto (
    Guid Id,
    string Name,
    Guid FishTypeId,
    string Habitat,
    decimal MaxSizeInInches,
    string Description,
    decimal Price,
    bool KoiFish
);
