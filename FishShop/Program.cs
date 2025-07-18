using System.Diagnostics;
using FishShop.Data;
using FishShop.Features.Fishes;
using FishShop.Features.FishesTypes;
using FishShop.Shared.ErrorHandling;
using FishShop.Shared.Timing;
using Microsoft.AspNetCore.HttpLogging;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("FishData");

//register service here
builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddSqlite<FishDataContext>(connString);
builder.Services.AddHttpLogging(options=>
{
    options.LoggingFields = HttpLoggingFields.RequestMethod |
                            HttpLoggingFields.RequestPath |
                            HttpLoggingFields.ResponseStatusCode |
                            HttpLoggingFields.Duration;
    options.CombineLogs = true;
});

var app = builder.Build();


//Fish Endpoints
app.MapFishes();

//FishType Endpoints
app.MapFishTypes();

// //write a middleware to count the duration of an action
// app.UseMiddleware<RequestTimingMiddleware>();

//using http logging
app.UseHttpLogging();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
}
app.UseStatusCodePages();


await app.InitializeDb();



app.Run();


