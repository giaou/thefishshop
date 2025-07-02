using System;
using FishShop.Models;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Data;

public static class DataExtensions
{
    public static void InitializeDb(this WebApplication app)
    {
        app.MigrateDb();
        app.SeedDb();
    }

    private static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        FishDataContext dbContext = scope.ServiceProvider.GetRequiredService<FishDataContext>();
        dbContext.Database.Migrate();
    }

    private static void SeedDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        FishDataContext dbContext = scope.ServiceProvider.GetRequiredService<FishDataContext>();

        if (!dbContext.types.Any())
        {
            dbContext.types.AddRange(
                new FishType { Name = "Freshwater" },
                new FishType { Name = "Saltwater" }
            );
            dbContext.SaveChanges();
        }
    }
}
