using System.Diagnostics;
using FishShop.Data;
using FishShop.Features.Fishes.Constants;
using FishShop.Models;
using Microsoft.Data.Sqlite;

namespace FishShop.Features.Fishes.GetFish;

public static class GetFishEndpoint
{
    public static void MapGetFish(this IEndpointRouteBuilder app){
        app.MapGet("/{id}", async (Guid id, FishDataContext dbContext, ILogger<Program> logger) =>
        {
            Fish? fish =  await dbContext.fishes.FindAsync(id);
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
}
