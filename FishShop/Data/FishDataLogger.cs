using System;

namespace FishShop.Data;

public class FishDataLogger(FishData data, ILogger<FishDataLogger> logger)
{
    public void printFishes()
    {
        foreach (var fish in data.GetFishes())
        {
            logger.LogInformation("FishId: {fishId} | FishName: {fishName}", fish.Id, fish.Name);
        }
    }
}
