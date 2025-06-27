using System;
using FishShop.Data;

namespace FishShop.Features.FishesTypes.GetFishTypes;

public static class GetFishTypesEndpoint
{
    public static void MapGetFishTypes(this IEndpointRouteBuilder app, FishData data)
    {
        app.MapGet("/", ()=>data.GetTypes().Select(type => new GetFishTypesDto(type.Id, type.Name)));
    }
}
