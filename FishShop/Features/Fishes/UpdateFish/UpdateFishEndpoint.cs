using System;
using FishShop.Data;

namespace FishShop.Features.Fishes.UpdateFish;

public static class UpdateFishEndpoint
{
    public static void MapUpdateFish(this IEndpointRouteBuilder app, FishData data){
        app.MapPut("/{id}", (Guid id, UpdateFishDto updatedFishDto) =>{
            //check for ID
            var existingFish = data.GetFish(id);
            if (existingFish is null) return Results.NotFound();

            //check for valid fish type
            var fishType = data.GetType(updatedFishDto.FishTypeId);
            if (fishType is null) return Results.BadRequest("Invalid Fish Type ID");

            //update new info
            existingFish.Name = updatedFishDto.Name;
            existingFish.Type = fishType;
            existingFish.Habitat = updatedFishDto.Habitat;
            existingFish.MaxSizeInInches = updatedFishDto.MaxSizeInInches;
            existingFish.Description = updatedFishDto.Description;
            existingFish.Price = updatedFishDto.Price;
            existingFish.KoiFish = updatedFishDto.KoiFish;

            return Results.NoContent();
        }).WithParameterValidation();
    }
}
