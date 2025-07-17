using System.Diagnostics;
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

//write a middleware to count the duration of an action
app.Use(async (context, next) =>
{
    var stopwatch = new Stopwatch();
    try
    {
        stopwatch.Start();
        await next(context);
    }
    finally
    {
        stopwatch.Stop();
        var elaspedMilliseconds = stopwatch.ElapsedMilliseconds;
        app.Logger.LogInformation("{RequestMethod} {RequestPath} completed with status {Status} in {ElapsedMilliseconds} ms",
                                    context.Request.Method,
                                    context.Request.Path,
                                    context.Response.StatusCode,
                                    elaspedMilliseconds);
    }
});

await app.InitializeDb();



app.Run();


