using FishShop.Data;

namespace FishShop.Features.Fishes.UpdateFish;

public static class UpdateFishEndpoint
{
    public static void MapUpdateFish(this IEndpointRouteBuilder app){
        app.MapPut("/{id}", (Guid id, UpdateFishDto updatedFishDto,FishDataContext dbContext) =>{
            //check for ID
            var existingFish = dbContext.fishes.Find(id);
            if (existingFish is null) return Results.NotFound();

            //update new info
            existingFish.Name = updatedFishDto.Name;
            existingFish.FishTypeId = updatedFishDto.FishTypeId;
            existingFish.Habitat = updatedFishDto.Habitat;
            existingFish.MaxSizeInInches = updatedFishDto.MaxSizeInInches;
            existingFish.Description = updatedFishDto.Description;
            existingFish.Price = updatedFishDto.Price;
            existingFish.KoiFish = updatedFishDto.KoiFish;

            //save changes
            dbContext.SaveChanges();

            return Results.NoContent();
        }).WithParameterValidation();
    }
}
