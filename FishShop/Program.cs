using System.ComponentModel.DataAnnotations;
using FishShop.Data;
using FishShop.Features.Fishes.GetFish;
using FishShop.Features.Fishes.GetFishes;
using FishShop.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FishData data = new();


app.MapGetFishes(data);

app.MapGet("/types", ()=>data.GetTypes().Select(type => new FishTypesDto(type.Id, type.Name)));

app.MapGetFish(data);

// app.MapPost("/fishes", (CreateFishDto newFishDto) =>
// {
//     var fishType = data.GetType(newFishDto.FishTypeId);
//     if (fishType is null) return Results.BadRequest("Invalid Fish Type Id");
//     var newFish = new Fish
//     {
//         Name = newFishDto.Name,
//         Type = fishType,
//         Habitat = newFishDto.Habitat,
//         MaxSizeInInches = newFishDto.MaxSizeInInches,
//         Description = newFishDto.Description,
//         Price = newFishDto.Price,
//         KoiFish = newFishDto.KoiFish
//     };
//     data.AddFish(newFish);

//     return Results.CreatedAtRoute(
//         GetFishEndpointName,
//         new { id = newFish.Id },
//         new FishDetailsDto(
//             newFish.Id,
//             newFish.Name,
//             newFish.Type.Id,
//             newFish.Habitat,
//             newFish.MaxSizeInInches,
//             newFish.Description,
//             newFish.Price,
//             newFish.KoiFish
//         )
//     );
// }).WithParameterValidation();

app.MapPut("/fishes/{id}", (Guid id, UpdateFishDto updatedFishDto) =>
{
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


app.MapDelete("/fishes/{id}", (Guid id) =>
{
    data.RemoveFish(id);
    return Results.NoContent();

});

app.Run();





public record CreateFishDto(
    [Required][StringLength(70)]string Name,
    Guid FishTypeId,
    [Required][StringLength(70)]string Habitat,
    decimal MaxSizeInInches,
    [Required][StringLength(1000)]string Description,
    decimal Price,
    bool KoiFish
);

public record UpdateFishDto(
    [Required][StringLength(70)]string Name,
    Guid FishTypeId,
    [Required][StringLength(70)]string Habitat,
    decimal MaxSizeInInches,
    [Required][StringLength(1000)]string Description,
    decimal Price,
    bool KoiFish
);

public record FishTypesDto(Guid Id, string Name);
