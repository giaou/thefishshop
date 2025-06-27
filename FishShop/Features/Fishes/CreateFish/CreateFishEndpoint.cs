using System;
using FishShop.Data;
using FishShop.Features.Fishes.Constants;
using FishShop.Models;

namespace FishShop.Features.Fishes.CreateFish;

public static class CreateFishEndpoint
{
    public static void MapCreateFish(this IEndpointRouteBuilder app, FishData data)
    {
        app.MapPost("/", (CreateFishDto newFishDto) =>{
            var fishType = data.GetType(newFishDto.FishTypeId);
            if (fishType is null) return Results.BadRequest("Invalid Fish Type Id");
            var newFish = new Fish
            {
                Name = newFishDto.Name,
                Type = fishType,
                Habitat = newFishDto.Habitat,
                MaxSizeInInches = newFishDto.MaxSizeInInches,
                Description = newFishDto.Description,
                Price = newFishDto.Price,
                KoiFish = newFishDto.KoiFish
            };
            data.AddFish(newFish);

            return Results.CreatedAtRoute(
                EndpointName.GetFish,
                new { id = newFish.Id },
                new FishDetailsDto(
                    newFish.Id,
                    newFish.Name,
                    newFish.Type.Id,
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
