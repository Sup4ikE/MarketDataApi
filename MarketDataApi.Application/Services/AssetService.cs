using MarketDataApi.Application.DTOs;
using MarketDataApi.Application.Interfaces;

namespace MarketDataApi.Application.Services;

public class AssetService: IAssetService
{
    private readonly IAssetRepository _assetRepository;

    public AssetService(IAssetRepository assetRepository)
    {
        _assetRepository = assetRepository;
    }


    public async Task<List<AssetDto>> GetAssets()
    {
        var assets = await _assetRepository.GetAssets();
        
        return assets.Select(x => new AssetDto
        {
            Symbol = x.Symbol,
            Kind = x.Kind
        }).ToList();
    }
}