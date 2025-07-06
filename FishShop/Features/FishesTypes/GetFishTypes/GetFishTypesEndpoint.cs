using FishShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Features.FishesTypes.GetFishTypes;

public static class GetFishTypesEndpoint
{
    public static void MapGetFishTypes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (FishDataContext dbContext)=>await dbContext.types.Select(type => new GetFishTypesDto(type.Id, type.Name)).AsNoTracking().ToListAsync());
    }
}
