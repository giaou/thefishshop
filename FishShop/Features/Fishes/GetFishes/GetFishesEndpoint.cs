using System;
using FishShop.Data;

namespace FishShop.Features.Fishes.GetFishes;

public static class GetFishesEndpoint
{

    public static void MapGetFishes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", (FishData data) => data.GetFishes().Select(fish => new FishSummaryDto(fish.Id, fish.Name, fish.Type.Name, fish.Habitat, fish.MaxSizeInInches, fish.Price)));
    }

}
