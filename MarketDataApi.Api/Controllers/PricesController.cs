using Microsoft.AspNetCore.Mvc;
using MarketDataApi.Application.Interfaces;

namespace MarketDataApi.Api.Controllers;

[ApiController]
[Route("api/prices")]
public class PricesController : ControllerBase
{
    private readonly IPriceService _priceService;

    public PricesController(IPriceService priceService)
    {
        _priceService = priceService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPrices([FromQuery] string symbols)
    {
        if (string.IsNullOrWhiteSpace(symbols))
            return BadRequest("Symbols query parameter is required");

        var symbolsList = symbols.Split(',');

        var result = new List<object>();

        foreach (var symbol in symbolsList.Select(s => s.Trim()))
        {
            try
            {
                var price = await _priceService.GetPrice(symbol);

                result.Add(new
                {
                    symbol,
                    price,
                    updatedAt = DateTime.UtcNow
                });
            }
            catch (Exception ex)
            {
                result.Add(new
                {
                    symbol,
                    error = ex.Message
                });
            }
        }

        return Ok(result);
    }
}