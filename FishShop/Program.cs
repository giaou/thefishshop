using FishShop.Data;
using FishShop.Features.Fishes;
using FishShop.Features.FishesTypes;
using FishShop.Features.FishesTypes.GetFishTypes;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FishData data = new();

//Fish Endpoints
app.MapFishes(data);

//FishType Endpoints
app.MapFishTypes(data);


app.Run();


