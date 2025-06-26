namespace FishShop.Features.Fishes.GetFishes;

public record FishSummaryDto(
    Guid Id,
    string Name,
    string Type,
    string Habitat,
    decimal MaxSizeInInches,
    decimal Price
);
