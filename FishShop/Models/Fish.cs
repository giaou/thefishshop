using System.ComponentModel.DataAnnotations;

namespace FishShop.Models;

public class Fish
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(70)]
    public string Name { get; set; }

    [Required]
    [StringLength(70)]
    public string Type { get; set; }

    [Required]
    [StringLength(70)]
    public string Habitat { get; set; }

    public decimal MaxSizeInInInches { get; set; }

    [Required]
    [StringLength(1000)]
    public string Description { get; set; }

    public decimal Price { get; set; }

    public bool KoiFish { get; set; }

}
