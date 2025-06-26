using System;
using FishShop.Data;

namespace FishShop.Features.Fishes.DeleteFish;

public static class DeleteFishEndpoint
{
    public static void MapDeleteFish(this IEndpointRouteBuilder app, FishData data)
    {
        app.MapDelete("/fishes/{id}", (Guid id) =>{
            data.RemoveFish(id);
            return Results.NoContent();
        });
    }
}
