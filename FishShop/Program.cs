using System.ComponentModel.DataAnnotations;
using FishShop.Data;
using FishShop.Features.Fishes.CreateFish;
using FishShop.Features.Fishes.DeleteFish;
using FishShop.Features.Fishes.GetFish;
using FishShop.Features.Fishes.GetFishes;
using FishShop.Features.Fishes.UpdateFish;
using FishShop.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FishData data = new();


app.MapGetFishes(data);
app.MapGetFish(data);
app.MapCreateFish(data);
app.MapUpdateFish(data);
app.MapDeleteFish(data);

app.MapGet("/types", ()=>data.GetTypes().Select(type => new FishTypesDto(type.Id, type.Name)));


app.Run();



public record FishTypesDto(Guid Id, string Name);
