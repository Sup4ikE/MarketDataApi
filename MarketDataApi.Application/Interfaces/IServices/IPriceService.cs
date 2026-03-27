namespace MarketDataApi.Application.Interfaces;

public interface IPriceService
{
    Task<decimal> GetPrice(string symbol);
}