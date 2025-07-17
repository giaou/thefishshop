using FishShop.Data;
using FishShop.Features.Fishes.Constants;
using FishShop.Models;
using Microsoft.Data.Sqlite;

namespace FishShop.Features.Fishes.GetFish;

public static class GetFishEndpoint
{
    public static void MapGetFish(this IEndpointRouteBuilder app){
        app.MapGet("/{id}", async (Guid id, FishDataContext dbContext) =>
        {
            Fish? fish = await FindFishAsync(id, dbContext);
            return fish is null ? Results.NotFound() : Results.Ok(
                new FishDetailsDto(
                    fish.Id,
                    fish.Name,
                    fish.FishTypeId,
                    fish.Habitat,
                    fish.MaxSizeInInches,
                    fish.Description,
                    fish.Price,
                    fish.KoiFish
                )
            );

        }).WithName(EndpointName.GetFish);
    }

    private static async Task<Fish> FindFishAsync(Guid id, FishDataContext dbContext)
    {
        throw new SqliteException("The database is not available", 14);
        return await dbContext.fishes.FindAsync(id);
    }
}
