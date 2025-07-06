using FishShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Features.Fishes.DeleteFish;

public static class DeleteFishEndpoint
{
    public static void MapDeleteFish(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id}", async (Guid id,FishDataContext dbContext) =>{
            await dbContext.fishes
                        .Where(fish => fish.Id == id)
                        .ExecuteDeleteAsync();
            return Results.NoContent();
        });
    }
}
