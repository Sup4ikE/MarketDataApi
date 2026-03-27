namespace MarketDataApi.Domain;

public class Asset
{
    public Guid Id { get; set; }
    public string Symbol { get; set; } = null!;
    public string Kind { get; set; } = null!;
    
    public string InstrumentId { get; set; } = null!;
}