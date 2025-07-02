using FishShop.Features.Fishes.CreateFish;
using FishShop.Features.Fishes.DeleteFish;
using FishShop.Features.Fishes.GetFish;
using FishShop.Features.Fishes.GetFishes;
using FishShop.Features.Fishes.UpdateFish;

namespace FishShop.Features.Fishes;

public static class FishsEndpoints
{
    public static void MapFishes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/fishes");
        group.MapGetFishes();
        group.MapGetFish();
        group.MapCreateFish();
        group.MapUpdateFish();
        group.MapDeleteFish();
    }
}
