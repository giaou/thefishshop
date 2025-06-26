using System.ComponentModel.DataAnnotations;

namespace FishShop.Features.Fishes.UpdateFish;

public record UpdateFishDto(
    [Required][StringLength(70)]string Name,
    Guid FishTypeId,
    [Required][StringLength(70)]string Habitat,
    decimal MaxSizeInInches,
    [Required][StringLength(1000)]string Description,
    decimal Price,
    bool KoiFish
);

