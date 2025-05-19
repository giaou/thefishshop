using FishShop.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Fish> fishes = [
    new Fish{
        Id=Guid.NewGuid(),
        Name="Neon Tetra",
        Type="Freshwater",
        Habitat="Southest Asia",
        MaxSizeInInInches= 1.5m,
        Description="Known for their vibrant blue and red stripes, neon tetras are peaceful schooling fish ideal for community tanks. They thrive in soft, acidic water and prefer to be kept in groups of six or more.",
        Price=3.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Guppy",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 2.5m,
        Description="Guppies are hardy, colorful fish that adapt well to various water conditions. They are livebearers, reproducing easily in captivity, and are suitable for beginners.",
        Price=10.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Betta",
        Type="Freshwater",
        Habitat="Southeast Asia",
        MaxSizeInInInches= 3.0m,
        Description="Bettas are known for their vivid colors and flowing fins. Males are territorial and should be housed alone or with compatible species. They breathe atmospheric air via a labyrinth organ.",
        Price=10.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Angelfish",
        Type="Freshwater",
        Habitat="Amazon Basin",
        MaxSizeInInInches= 6.0m,
        Description="Angelfish have a distinctive triangular shape and long fins. They prefer tall tanks with plenty of swimming space and are generally peaceful but may become territorial when breeding.",
        Price=18.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Tiger Barb",
        Type="Freshwater",
        Habitat="Southeast Asia",
        MaxSizeInInInches= 3.0m,
        Description="Tiger barbs are active, schooling fish with bold black stripes. They can be fin-nippers, so they are best kept in groups of six or more to minimize aggression.",
        Price=5.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Peppered Cory",
        Type="Freshwater",
        Habitat="South America",
        MaxSizeInInInches= 2.5m,
        Description="These bottom-dwelling catfish are peaceful and thrive in groups. They help keep the tank clean by scavenging leftover food and prefer soft substrates to protect their barbels.",
        Price=9.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Giant Danio",
        Type="Freshwater",
        Habitat="South Asia",
        MaxSizeInInInches= 4.0m,
        Description="Giant danios are fast swimmers and prefer spacious tanks with strong currents. They are schooling fish and should be kept in groups to reduce stress.",
        Price=6.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Killifish",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 2.5m,
        Description="Killifish are known for their vibrant colors and unique breeding behaviors. Many species have short lifespans and require specific conditions for breeding, making them more suitable for experienced aquarists.",
        Price=20.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Dwarf Cichlids",
        Type="Freshwater",
        Habitat="South America",
        MaxSizeInInInches= 3.0m,
        Description="Dwarf cichlids are colorful and exhibit interesting behaviors, especially during breeding. They prefer soft, acidic water and are best kept in species-specific or carefully planned community tanks.",
        Price=30.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Peppermint Pleco",
        Type="Freshwater",
        Habitat="South America",
        MaxSizeInInInches= 24.0m,
        Description="Plecos are algae-eating catfish that help keep tanks clean. While some species remain small, others can grow quite large and require ample space.",
        Price=60.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Ocellaris Clownfish",
        Type="Saltwater",
        Habitat="Indo-Pacific",
        MaxSizeInInInches= 4.0m,
        Description="Popularized by media, these clownfish are hardy and adapt well to captive conditions. They can form symbiotic relationships with anemones but can thrive without them.",
        Price=25.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="True Percula Clownfish",
        Type="Saltwater",
        Habitat="Indo-Pacific",
        MaxSizeInInInches= 4.0m,
        Description="Similar to the ocellaris, percula clownfish have thicker black margins on their white bands. They are peaceful and suitable for reef tanks.",
        Price=42.95m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Banggai Cardinalfish",
        Type="Saltwater",
        Habitat="Indonesia",
        MaxSizeInInInches= 3.0m,
        Description="Banggai cardinalfish are peaceful and easy to care for, making them ideal for beginners. They have a striking appearance with black vertical stripes and long fins.",
        Price=14.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Spotted Watchman Goby",
        Type="Saltwater",
        Habitat="Indo-Pacific",
        MaxSizeInInInches= 4.0m,
        Description="These gobies are known for their symbiotic relationship with pistol shrimp. They are peaceful and help maintain the substrate by digging burrows.",
        Price=30.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Green Spotted Puffer",
        Type="Brackish to Saltwater",
        Habitat="Amazon Basin",
        MaxSizeInInInches= 6.0m,
        Description="Green spotted puffers are intelligent and can recognize their owners. They require specific water conditions and a diet that helps wear down their continuously growing teeth.",
        Price=1.69m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Mandarinfish",
        Type="Saltwater",
        Habitat="Pacific Ocean",
        MaxSizeInInInches= 3.0m,
        Description="Mandarinfish are known for their vivid coloration. They require established tanks with abundant live copepods, as they are picky eaters.",
        Price=40.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Royal Gramma",
        Type="Saltwater",
        Habitat="Caribbean",
        MaxSizeInInInches= 3.0m,
        Description="Royal grammas are peaceful and have a striking purple to yellow gradient. They prefer caves and overhangs in the aquarium.",
        Price=30.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Firefish Goby",
        Type="Saltwater",
        Habitat="Indo-Pacific",
        MaxSizeInInInches= 3.0m,
        Description="The Firefish Goby is a peaceful and vibrant addition to reef aquariums. It features a pale yellow head that transitions to a fiery red-orange tail, with an elongated dorsal fin that flicks as it swims. Native to the Indo-Pacific, it prefers sandy or rubble areas near coral reefs. In aquariums, they thrive in tanks with plenty of rockwork, crevices, and overhangs for hiding. They are reef-safe and generally get along with other peaceful species. However, they may exhibit territorial behavior towards conspecifics in smaller tanks. Providing a secure lid is recommended, as they are known to jump when startled.",
        Price=29.9m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Yellow Tang",
        Type="Saltwater",
        Habitat="Pacific Ocean, Hawaii",
        MaxSizeInInInches= 8.0m,
        Description="The Yellow Tang is a vibrant, bright-yellow surgeonfish prized for its striking coloration and active swimming behavior. Native to the reefs of the Pacific Ocean, especially around Hawaii, they are herbivorous and excellent natural grazers, helping to control algae in aquariums. They prefer tanks with ample swimming space and live rock for grazing. Due to collection bans in Hawaii, captive-bred specimens are now more common, offering hardier and more disease-resistant alternatives to wild-caught individuals.",
        Price=250.0m,
        KoiFish=false
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Blue Tang",
        Type="Saltwater",
        Habitat="Indo-Pacific",
        MaxSizeInInInches= 12.0m,
        Description="Also known as the Regal Tang or Hippo Tang, this species is renowned for its vibrant blue body and yellow tail. Native to the Indo-Pacific, they are active swimmers requiring large tanks with plenty of open space and hiding spots. They are generally peaceful but may show aggression towards similar species. Their diet should be rich in marine-based algae and supplemented with meaty foods. Captive-bred specimens are available and are often more adaptable to aquarium life.",
        Price=212.98m
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Kohaku",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 36.0m,
        Description="Kohaku koi are renowned for their pristine white bodies adorned with bold red (hi) markings. As one of the \"Big Three\" koi varieties, they are highly prized in koi shows and collections.",
        Price=5000.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Taisho Sanke",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 36.0m,
        Description="Sanke koi feature a white base with red and black markings. The black (sumi) patterns are typically confined to the upper body, distinguishing them from Showa koi.",
        Price=7000.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Showa Sanshoku",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 36.0m,
        Description="Showa koi have a black base color with red and white markings. Unlike Sanke, the black patterns extend below the lateral line and can appear on the head.",
        Price=10000.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Asagi",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 24.0m,
        Description="Asagi koi display a blue-gray net-like pattern on their backs with red or orange accents on the belly, fins, and gill plates. They are one of the oldest koi varieties.",
        Price=1000.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Shusui",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 24.0m,
        Description="Shusui are the scaleless (Doitsu) version of Asagi, featuring a blue body with a single row of dark scales along the dorsal line and red or orange markings on the sides.",
        Price=350.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Platinum Ogon",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 36.0m,
        Description="Ogon koi are solid-colored metallic koi, commonly in gold (Yamabuki Ogon) or platinum (Platinum Ogon). Their uniform coloration and metallic sheen make them stand out in ponds.",
        Price=1000.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Butterfly Koi",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 40.0m,
        Description="Also known as Longfin Koi, Butterfly Koi are characterized by their elongated, flowing fins and tails. They come in various color patterns and are appreciated for their graceful appearance.",
        Price=350.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Ginrin",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 36.0m,
        Description="Ginrin koi possess reflective, diamond-shaped scales that sparkle in the light. This trait can be combined with various koi varieties, enhancing their visual appeal.",
        Price=400.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Tancho",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 36.0m,
        Description="Tancho koi are distinguished by a single red spot on the head, resembling the Japanese flag. The rest of the body is typically pure white.",
        Price=2000.0m,
        KoiFish=true
    },
    new Fish{
        Id=Guid.NewGuid(),
        Name="Hi Utsuri",
        Type="Freshwater",
        Habitat="Global",
        MaxSizeInInInches= 30.0m,
        Description="Hi Utsuri koi have a black base with vibrant red markings. The contrast between the two colors creates a striking appearance.",
        Price=3000.0m,
        KoiFish=true
    },
];

app.MapGet("/fishes", () => fishes);

app.MapGet("/fishes/{id}", (Guid id) =>
{
    var fish = fishes.Find(fish => id == fish.Id);
    return fish is null ? Results.NotFound() : Results.Ok(fish);
    
});

app.Run();
