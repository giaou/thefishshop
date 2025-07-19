namespace FishShop.Features.Fishes.GetFishes;

public record GetFishesDto (int PageNumber = 1, int PageSize = 5);

public record FishesPageDto (int TotalPage, IEnumerable<FishSummaryDto> data);

public record FishSummaryDto(
    Guid Id,
    string Name,
    string Type,
    string Habitat,
    decimal MaxSizeInInches,
    decimal Price
);
