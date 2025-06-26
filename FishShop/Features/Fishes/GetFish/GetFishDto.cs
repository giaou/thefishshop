namespace FishShop.Features.Fishes.GetFish;

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