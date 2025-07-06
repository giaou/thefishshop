using System;
using System.Threading.Tasks;
using FishShop.Models;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Data;

public static class DataExtensions
{
    public static async Task InitializeDb(this WebApplication app)
    {
        await app.MigrateDbAsync();
        await app.SeedDbAsync();
    }

    private static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        FishDataContext dbContext = scope.ServiceProvider.GetRequiredService<FishDataContext>();
        await dbContext.Database.MigrateAsync();
    }

    private static async Task SeedDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        FishDataContext dbContext = scope.ServiceProvider.GetRequiredService<FishDataContext>();

        if (!dbContext.types.Any())
        {
            dbContext.types.AddRange(
                new FishType { Name = "Freshwater" },
                new FishType { Name = "Saltwater" }
            );
            await dbContext.SaveChangesAsync();
        }
    }
}
