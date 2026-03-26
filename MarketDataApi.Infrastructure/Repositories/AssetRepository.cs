using MarketDataApi.Application.Interfaces;
using MarketDataApi.Domain;
using MarketDataApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MarketDataApi.Infrastructure.Repositories;

public class AssetRepository: IAssetRepository
{
    private readonly ApplicationDbContext _context;
    
    public AssetRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<List<Asset>> GetAssets()
    {
        IQueryable<Asset> query = _context.Assets.AsNoTracking();
        
        return await query.ToListAsync();
    }
}