using FishShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Features.Fishes.DeleteFish;

public static class DeleteFishEndpoint
{
    public static void MapDeleteFish(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id}", (Guid id,FishDataContext dbContext) =>{
            dbContext.fishes
                        .Where(fish => fish.Id == id)
                        .ExecuteDelete();
            return Results.NoContent();
        });
    }
}
