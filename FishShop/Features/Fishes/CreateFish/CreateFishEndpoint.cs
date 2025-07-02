using System;
using FishShop.Data;
using FishShop.Features.Fishes.Constants;
using FishShop.Models;

namespace FishShop.Features.Fishes.CreateFish;

public static class CreateFishEndpoint
{
    public static void MapCreateFish(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", (CreateFishDto newFishDto,FishDataContext dbContext) =>{
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
            dbContext.SaveChanges();
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
