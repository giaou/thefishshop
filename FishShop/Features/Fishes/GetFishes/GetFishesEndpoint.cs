using System.Net.WebSockets;
using FishShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Features.Fishes.GetFishes;

public static class GetFishesEndpoint
{

    public static void MapGetFishes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (FishDataContext dbContext, [AsParameters] GetFishesDto request) =>
        {
            var skipCount = (request.PageNumber - 1) * request.PageSize;

            var filteredFishes = dbContext.fishes.Where(fish => string.IsNullOrWhiteSpace(request.Name)
                                                        || EF.Functions.Like(fish.Name,$"{request.Name}%"));

            var fishesOnPage = await dbContext.fishes
                                                .OrderBy(fish => fish.Name)
                                                .Skip(skipCount)
                                                .Take(request.PageSize)
                                                .Include(fish => fish.Type)
                                                .Select(fish => new FishSummaryDto(
                                                        fish.Id,
                                                        fish.Name,
                                                        fish.Type!.Name,
                                                        fish.Habitat,
                                                        fish.MaxSizeInInches,
                                                        fish.Price
                                                        )).AsNoTracking()
                                                        .ToListAsync();

            var totalFishes = await filteredFishes.CountAsync();
            var totalPages = (int)Math.Ceiling(totalFishes / (double)request.PageSize);

            return new FishesPageDto(totalPages, fishesOnPage);
        });
    }

}
