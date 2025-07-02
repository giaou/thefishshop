using FishShop.Data;
using FishShop.Features.Fishes;
using FishShop.Features.FishesTypes;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("FishData");

//register service here
builder.Services.AddSqlite<FishDataContext>(connString);
var app = builder.Build();


//Fish Endpoints
app.MapFishes();

//FishType Endpoints
app.MapFishTypes();

app.InitializeDb();


app.Run();


