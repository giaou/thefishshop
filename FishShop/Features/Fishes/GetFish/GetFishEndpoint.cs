using FishShop.Data;
using FishShop.Features.Fishes.Constants;
using FishShop.Models;

namespace FishShop.Features.Fishes.GetFish;

public static class GetFishEndpoint
{
    public static void MapGetFish(this IEndpointRouteBuilder app){
        app.MapGet("/{id}", (Guid id, FishDataContext dbContext) =>{
            Fish? fish = dbContext.fishes.Find(id);
            return fish is null ? Results.NotFound() : Results.Ok(
                new FishDetailsDto(
                    fish.Id,
                    fish.Name,
                    fish.FishTypeId,
                    fish.Habitat,
                    fish.MaxSizeInInches,
                    fish.Description,
                    fish.Price,
                    fish.KoiFish
                )
            );
    
        }).WithName(EndpointName.GetFish);
    }
}
