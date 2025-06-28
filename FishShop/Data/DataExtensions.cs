using System;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Data;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        FishDataContext dbContext = scope.ServiceProvider.GetRequiredService<FishDataContext>();
        dbContext.Database.Migrate();
    }
}
