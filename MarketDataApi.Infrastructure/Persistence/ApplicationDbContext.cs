using MarketDataApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace MarketDataApi.Infrastructure.Persistence;

public class ApplicationDbContext: DbContext
{
    public DbSet<Asset> Assets { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Asset>().HasData(
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111001"), Symbol = "EURUSD", Kind = "forex", InstrumentId = "019cfb9b-5d5b-73a3-a2e8-5c537ee593cd" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111002"), Symbol = "GBPUSD", Kind = "forex", InstrumentId = "019cfb9b-5be1-73e9-9797-8eac7cda5349" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111003"), Symbol = "USDJPY", Kind = "forex", InstrumentId = "019cfb9b-5c16-7217-8108-2a1dfe834b90" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111004"), Symbol = "USDCHF", Kind = "forex", InstrumentId = "019cfb9b-5c79-7f09-993b-8e0e996f58fe" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111005"), Symbol = "USDCAD", Kind = "forex", InstrumentId = "019cfb9b-5e7a-7199-b906-93f3e818bf62" },

            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111006"), Symbol = "AUDUSD", Kind = "forex", InstrumentId = "019cfb9b-5c36-7326-b890-d37568bd3637" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111007"), Symbol = "AUDNZD", Kind = "forex", InstrumentId = "019cfb9b-5c0c-7356-8f75-f627cd37f302" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111008"), Symbol = "AUDJPY", Kind = "forex", InstrumentId = "019cfb9b-5da5-76fc-b6c0-1b9c270040c3" },

            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111009"), Symbol = "EURAUD", Kind = "forex", InstrumentId = "019cfb9b-5ccd-7064-bb8c-4aa47a93c6f1" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111010"), Symbol = "EURCAD", Kind = "forex", InstrumentId = "019cfb9b-5bbd-7bf6-975a-19a538210610" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111011"), Symbol = "EURCHF", Kind = "forex", InstrumentId = "019cfb9b-5d23-7009-9ced-057bc85fbdf3" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111012"), Symbol = "EURGBP", Kind = "forex", InstrumentId = "019cfb9b-5c6f-7eac-b85c-0c9dd8a09e4b" },

            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111013"), Symbol = "EURJPY", Kind = "forex", InstrumentId = "019cfb9b-5d82-75a9-9df4-fde04e4fd481" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111014"), Symbol = "EURNZD", Kind = "forex", InstrumentId = "019cfb9b-5e3d-7dc8-b4c3-fa4cc90997ba" },

            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111015"), Symbol = "GBPJPY", Kind = "forex", InstrumentId = "019cfb9b-5d0c-7111-9df6-fa14c5f4c87d" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111016"), Symbol = "GBPCHF", Kind = "forex", InstrumentId = "019cfb9b-5dbb-7cc9-ba07-0ddb62828135" },

            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111017"), Symbol = "NZDUSD", Kind = "forex", InstrumentId = "019cfb9b-5c57-7a5e-bed8-f0e7a7558526" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111018"), Symbol = "NZDCHF", Kind = "forex", InstrumentId = "019cfb9b-6035-7777-8217-f936ffaed040" },

            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111019"), Symbol = "USDSEK", Kind = "forex", InstrumentId = "019cfb9b-5ec6-7a27-b223-fa0c0f5b13c6" },
            new Asset { Id = Guid.Parse("11111111-1111-1111-1111-111111111020"), Symbol = "USDPLN", Kind = "forex", InstrumentId = "019cfb9b-5c41-7907-b0d7-1eb0dd665012" }
            
            // you can add more ... 
        );
    }
}