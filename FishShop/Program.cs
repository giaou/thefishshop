using FishShop.Data;
using FishShop.Features.Fishes;
using FishShop.Features.FishesTypes;
using FishShop.Features.FishesTypes.GetFishTypes;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("FishData");

//register service here
builder.Services.AddTransient<FishDataLogger>();
builder.Services.AddSingleton<FishData>();
builder.Services.AddSqlite<FishDataContext>(connString);

var app = builder.Build();


//Fish Endpoints
app.MapFishes();

//FishType Endpoints
app.MapFishTypes();

app.MigrateDb();


app.Run();


