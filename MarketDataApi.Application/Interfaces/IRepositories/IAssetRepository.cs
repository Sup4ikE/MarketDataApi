using MarketDataApi.Domain;

namespace MarketDataApi.Application.Interfaces;

public interface IAssetRepository
{
    public Task<List<Asset>> GetAssets();
    Task<Asset?> GetBySymbol(string symbol);
}