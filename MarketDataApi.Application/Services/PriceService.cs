using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using MarketDataApi.Application.Interfaces;
using MarketDataApi.Application.Settings;
using Microsoft.Extensions.Options;

public class PriceService : IPriceService
{
    private readonly IAssetRepository _assetRepository;
    private readonly string _token;

    public PriceService(
        IAssetRepository assetRepository,
        IOptions<FintachartsSettings> options)
    {
        _assetRepository = assetRepository;
        _token = options.Value.Token;
    }

    public async Task<decimal> GetPrice(string symbol)
    {
        // Get asset by symbol
        var asset = await _assetRepository.GetBySymbol(symbol);

        if (asset == null)
            throw new Exception("Asset not found");

        // Connect to websocket
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        using var ws = new ClientWebSocket();

        var url =
            $"wss://platform.fintacharts.com/api/streaming/ws/v1/realtime?token={_token}";

        // Subscribe to asset
        await ws.ConnectAsync(new Uri(url), CancellationToken.None);

        var subscribe = new
        {
            type = "l1-subscription",
            id = "1",
            instrumentId = asset.InstrumentId,
            provider = "simulation",
            subscribe = true,
            kinds = new[] { "ask", "bid", "last" }
        };

        var json = JsonSerializer.Serialize(subscribe);
        var bytes = Encoding.UTF8.GetBytes(json);

        // Send subscribe message
        await ws.SendAsync(
            bytes,
            WebSocketMessageType.Text,
            true,
            CancellationToken.None);

        var buffer = new byte[4096];
        
        while (true)
        {
            WebSocketReceiveResult result;

            try
            {
                result = await ws.ReceiveAsync(buffer, cts.Token);
            }
            catch (OperationCanceledException)
            {
                throw new Exception("Price request timeout");
            }
            
            var response = Encoding.UTF8.GetString(buffer, 0, result.Count);

            // Parse response
            using var doc = JsonDocument.Parse(response);
            var root = doc.RootElement;

            if (root.TryGetProperty("type", out var typeProp) &&
                typeProp.GetString() == "l1-update")
            {
                if (root.TryGetProperty("ask", out var ask) &&
                    ask.TryGetProperty("price", out var askPrice))
                {
                    return askPrice.GetDecimal();
                }

                if (root.TryGetProperty("bid", out var bid) &&
                    bid.TryGetProperty("price", out var bidPrice))
                {
                    return bidPrice.GetDecimal();
                }

                if (root.TryGetProperty("last", out var last) &&
                    last.TryGetProperty("price", out var lastPrice))
                {
                    return lastPrice.GetDecimal();
                }
            }
        }
    }
}
