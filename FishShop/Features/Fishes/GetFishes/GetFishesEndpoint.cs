using FishShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Features.Fishes.GetFishes;

public static class GetFishesEndpoint
{

    public static void MapGetFishes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/",  async (FishDataContext dbContext) => await dbContext.fishes
                                                        .Include(fish => fish.Type)
                                                        .Select(fish => new FishSummaryDto(
            fish.Id,
            fish.Name,
            fish.Type!.Name,
            fish.Habitat,
            fish.MaxSizeInInches,
            fish.Price))
                        .AsNoTracking()
                        .ToListAsync());
    }

}
