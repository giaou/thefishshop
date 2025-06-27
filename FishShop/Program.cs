using FishShop.Data;
using FishShop.Features.Fishes;
using FishShop.Features.FishesTypes;
using FishShop.Features.FishesTypes.GetFishTypes;


var builder = WebApplication.CreateBuilder(args);

//register service here
builder.Services.AddTransient<FishDataLogger>();
builder.Services.AddScoped<FishData>();

var app = builder.Build();


//Fish Endpoints
app.MapFishes();

//FishType Endpoints
app.MapFishTypes();


app.Run();


