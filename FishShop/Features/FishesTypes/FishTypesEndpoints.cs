using System;
using FishShop.Data;
using FishShop.Features.FishesTypes.GetFishTypes;

namespace FishShop.Features.FishesTypes;

public static class FishTypesEndpoints
{
    public static void MapFishTypes(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/types");
        group.MapGetFishTypes();
    }
}
