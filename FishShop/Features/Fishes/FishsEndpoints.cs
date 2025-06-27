using System;
using FishShop.Data;
using FishShop.Features.Fishes.CreateFish;
using FishShop.Features.Fishes.DeleteFish;
using FishShop.Features.Fishes.GetFish;
using FishShop.Features.Fishes.GetFishes;
using FishShop.Features.Fishes.UpdateFish;

namespace FishShop.Features.Fishes;

public static class FishsEndpoints
{
    public static void MapFishes(this IEndpointRouteBuilder app, FishData data)
    {
        var group = app.MapGroup("/fishes");
        group.MapGetFishes(data);
        group.MapGetFish(data);
        group.MapCreateFish(data);
        group.MapUpdateFish(data);
        group.MapDeleteFish(data);
    }
}
