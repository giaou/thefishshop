using System;
using FishShop.Data;

namespace FishShop.Features.FishesTypes.GetFishTypes;

public static class GetFishTypesEndpoint
{
    public static void MapGetFishTypes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", (FishData data)=>data.GetTypes().Select(type => new GetFishTypesDto(type.Id, type.Name)));
    }
}
