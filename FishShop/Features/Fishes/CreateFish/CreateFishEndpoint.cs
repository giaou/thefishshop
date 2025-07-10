using FishShop.Data;
using FishShop.Features.Fishes.Constants;
using FishShop.Models;

namespace FishShop.Features.Fishes.CreateFish;

public static class CreateFishEndpoint
{
    public static void MapCreateFish(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", async (CreateFishDto newFishDto,FishDataContext dbContext, ILoggerFactory loggerFactory) =>{
            var newFish = new Fish
            {
                Name = newFishDto.Name,
                FishTypeId = newFishDto.FishTypeId,
                Habitat = newFishDto.Habitat,
                MaxSizeInInches = newFishDto.MaxSizeInInches,
                Description = newFishDto.Description,
                Price = newFishDto.Price,
                KoiFish = newFishDto.KoiFish
            };

            dbContext.fishes.Add(newFish);
            await dbContext.SaveChangesAsync();
            var logger = loggerFactory.CreateLogger("Fishes");
            logger.LogInformation("Create fish {FishName} with price {FishPrice}", newFish.Name, newFish.Price);
            return Results.CreatedAtRoute(
                EndpointName.GetFish,
                new { id = newFish.Id },
                new FishDetailsDto(
                    newFish.Id,
                    newFish.Name,
                    newFish.FishTypeId,
                    newFish.Habitat,
                    newFish.MaxSizeInInches,
                    newFish.Description,
                    newFish.Price,
                    newFish.KoiFish
                )
            );
        }).WithParameterValidation();
    }
}
