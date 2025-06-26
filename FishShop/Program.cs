using System.ComponentModel.DataAnnotations;
using FishShop.Data;
using FishShop.Features.Fishes.CreateFish;
using FishShop.Features.Fishes.DeleteFish;
using FishShop.Features.Fishes.GetFish;
using FishShop.Features.Fishes.GetFishes;
using FishShop.Features.Fishes.UpdateFish;
using FishShop.Features.FishesTypes.GetFishTypes;
using FishShop.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FishData data = new();

//Fish Endpoints
app.MapGetFishes(data);
app.MapGetFish(data);
app.MapCreateFish(data);
app.MapUpdateFish(data);
app.MapDeleteFish(data);

//FishType Endpoints
app.MapGetFishTypes(data);


app.Run();


