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
            new Asset { Id = Guid.Parse("019cfb9b-5d5b-73a3-a2e8-5c537ee593cd"), Symbol = "EURUSD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5be1-73e9-9797-8eac7cda5349"), Symbol = "GBPUSD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5c16-7217-8108-2a1dfe834b90"), Symbol = "USDJPY", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5c79-7f09-993b-8e0e996f58fe"), Symbol = "USDCHF", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5e7a-7199-b906-93f3e818bf62"), Symbol = "USDCAD", Kind = "forex" },

            new Asset { Id = Guid.Parse("019cfb9b-5c36-7326-b890-d37568bd3637"), Symbol = "AUDUSD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5c0c-7356-8f75-f627cd37f302"), Symbol = "AUDNZD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5da5-76fc-b6c0-1b9c270040c3"), Symbol = "AUDJPY", Kind = "forex" },

            new Asset { Id = Guid.Parse("019cfb9b-5ccd-7064-bb8c-4aa47a93c6f1"), Symbol = "EURAUD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5bbd-7bf6-975a-19a538210610"), Symbol = "EURCAD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5d23-7009-9ced-057bc85fbdf3"), Symbol = "EURCHF", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5c6f-7eac-b85c-0c9dd8a09e4b"), Symbol = "EURGBP", Kind = "forex" },

            new Asset { Id = Guid.Parse("019cfb9b-5d82-75a9-9df4-fde04e4fd481"), Symbol = "EURJPY", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5e3d-7dc8-b4c3-fa4cc90997ba"), Symbol = "EURNZD", Kind = "forex" },

            new Asset { Id = Guid.Parse("019cfb9b-5d0c-7111-9df6-fa14c5f4c87d"), Symbol = "GBPJPY", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5dbb-7cc9-ba07-0ddb62828135"), Symbol = "GBPCHF", Kind = "forex" },

            new Asset { Id = Guid.Parse("019cfb9b-5c57-7a5e-bed8-f0e7a7558526"), Symbol = "NZDUSD", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-6035-7777-8217-f936ffaed040"), Symbol = "NZDCHF", Kind = "forex" },

            new Asset { Id = Guid.Parse("019cfb9b-5ec6-7a27-b223-fa0c0f5b13c6"), Symbol = "USDSEK", Kind = "forex" },
            new Asset { Id = Guid.Parse("019cfb9b-5c41-7907-b0d7-1eb0dd665012"), Symbol = "USDPLN", Kind = "forex" }
            
            // you can add more ... 
        );
    }
}