using MarketDataApi.Application.DTOs;

namespace MarketDataApi.Application.Interfaces;

public interface IAssetService
{
    public Task<List<AssetDto>> GetAssets();
}