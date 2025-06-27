using System;
using FishShop.Data;

namespace FishShop.Features.Fishes.DeleteFish;

public static class DeleteFishEndpoint
{
    public static void MapDeleteFish(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id}", (Guid id,FishData data) =>{
            data.RemoveFish(id);
            return Results.NoContent();
        });
    }
}
