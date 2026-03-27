using MarketDataApi.Application.Interfaces;
using MarketDataApi.Domain;
using MarketDataApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MarketDataApi.Infrastructure.Repositories;

public class AssetRepository: IAssetRepository
{
    private readonly ApplicationDbContext _context;
    private IAssetRepository _assetRepositoryImplementation;

    public AssetRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<List<Asset>> GetAssets()
    {
        IQueryable<Asset> query = _context.Assets.AsNoTracking();
        
        return await query.ToListAsync();
    }

    public async Task<Asset?> GetBySymbol(string symbol)
    {
        return await _context.Assets
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Symbol == symbol);
    }
}