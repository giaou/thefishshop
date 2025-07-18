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
            try
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
            }
            catch (Exception ex)
            {
                var traceId = Activity.Current?.TraceId;
                logger.LogError(ex, "Could not process a request on machine {Machine}, TraceId: {TraceId}",
                                    Environment.MachineName,
                                    traceId);
                return Results.Problem(
                    title: "An error occurred while trying to lookup your input",
                    statusCode: StatusCodes.Status500InternalServerError,
                    extensions: new Dictionary<string, object?>
                    {
                        { "traceId",traceId.ToString()}
                    }
                );
            }

        }).WithName(EndpointName.GetFish);
    }

    private static async Task<Fish> FindFishAsync(Guid id, FishDataContext dbContext)
    {
        throw new SqliteException("The database is not available", 14);
        return await dbContext.fishes.FindAsync(id);
    }
}
