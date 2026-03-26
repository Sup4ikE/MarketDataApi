using MarketDataApi.Application.DTOs;
using MarketDataApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MarketDataApi.Api.Controllers;

[ApiController]
[Route("api/assets")]
public class AssetController : ControllerBase
{
    private readonly IAssetService _assetService;

    public AssetController(IAssetService assetService)
    {
        _assetService = assetService;
    }


    [HttpGet]
    public async Task<ActionResult<List<AssetDto>>> GetAssets()
    {
        return Ok(await _assetService.GetAssets());
    }
}