using System;
using FishShop.Models;
using Microsoft.EntityFrameworkCore;

namespace FishShop.Data;

public class FishDataContext(DbContextOptions<FishDataContext> options) : DbContext(options)
{
    public DbSet<Fish> fishes => Set<Fish>();
    public DbSet<FishType> types => Set<FishType>();
}
