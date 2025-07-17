using System.Diagnostics;
using FishShop.Data;
using FishShop.Features.Fishes;
using FishShop.Features.FishesTypes;
using FishShop.Shared.Timing;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("FishData");

//register service here
builder.Services.AddSqlite<FishDataContext>(connString);
var app = builder.Build();


//Fish Endpoints
app.MapFishes();

//FishType Endpoints
app.MapFishTypes();

//write a middleware to count the duration of an action
app.UseMiddleware<RequestTimingMiddleware>();

await app.InitializeDb();



app.Run();


