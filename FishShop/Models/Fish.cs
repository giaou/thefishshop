using System.ComponentModel.DataAnnotations;

namespace FishShop.Models;

public class Fish
{
    public Guid Id { get; set; }

  
    public string Name { get; set; }

    public FishType? Type { get; set; }

    public Guid FishTypeId { get; set; }


    public string Habitat { get; set; }

    public decimal MaxSizeInInches { get; set; }


    public string Description { get; set; }

    public decimal Price { get; set; }

    public bool KoiFish { get; set; }

}
