# ExchangeRate.API.Client

Implementation of API-client for [exchange.artbit.one](https://ex.artbit.one/) for searching for most profitable P2P rates for buying or selling cryptos all across most popular exchange markets 🚀

Client works with exchanges:
1. Binance
2. Bybit
3. OKX
4. Huobi

Allowed cryptos:
1. USDT

Allowed fiat currencies:
1. Ruble

Allowed banks:
1. Tinkoff 
2. Sber
3. Raifaisen
4. SBP

## Setup ⚙️
Clone this repo and add artbit.API.Client.csproj to your .Net Core solution                  
                  
Register dependencies in your Startup.cs                 
```c#
public void ConfigureServices(IServiceCollection services)
{
  services
    .RegisterExchangeRateApiClient();
}
```
That's all. Now you can query best rates

## Play on exchanges 🎮
Example of making a simple query to find best selling rate for USDT and Ruble on Binance and Bybit
```c#
public BestRatesContoller(IExchangeApiClient exchangeApiClient)
{
    _exchangeApiClient = exchangeApiClient;
}

public async Task GetBestRates()
{
    var binanceExchangeId = 1;
    var bybitExchangeId = 2;
    var tinkoffBankId = 1;
    var usdtAssetId = 1;
    var rubleAssetId = 1;

    await _exchangeApiClient.GetBestRatesAsync(TradeDirectionEnum.SELL, new ExchangeRateFilter
    {
        Exchanges = new int[] { binanceExchangeId, bybitExchangeId },
        Banks = new int[] { tinkoffBankId },
        CryptoAssets = new int[] { usdtAssetId },
        FiatAsset = rubleAssetId
    });
}
```

You can get all available options for filtering by making this query
```c#
  await _exchangeApiClient.GetFilterOptionsAsync();
```

## API Contracts 📝
```c#
public class ExchangeRateFilterOptions
{
    public IEnumerable<Bank> Banks { get; set; }
    public IEnumerable<KeyValuePair<int, string>> Exchanges { get; set; }
    public IEnumerable<KeyValuePair<int, string>> FiatAssets { get; set; }    
    public IEnumerable<KeyValuePair<int, string>> CryptoAssets { get; set; }
}
```

Querying for best rates returns grouped by exchange results
Rates array field contains several ads of trades are ordered accordingly to query type. 
Pick the first element in Rates array to get the best rate whether you selling or buying cryptos 👍
```c#    
    public class ExchangeRates
    {        
        public int Exchange { get; set; }
        public ICollection<P2PTrade> Rates { get; set; }
    }
```

```c#    
public class P2PTrade
{    
    public System.DateTimeOffset? DateUtc { get; set; }
    public string TraderId { get; set; }
    public string Trader { get; set; }    
    public int OrdersAmount { get; set; }
    public double CompletedOrdersPercent { get; set; }
    public double AvailableAmount { get; set; }
    public double Price { get; set; }
    public ICollection<int> Banks { get; set; }
    public int Exchange { get; set; }
    public TradeDirectionEnum Direction { get; set; }
    public double MinAmount { get; set; }
    public double MaxAmount { get; set; }
    public double PlatformCommission { get; set; }
    public string Link { get; set; }
}
```
Most useful fields of P2PTrade contract are Price and Link. 
Link field contains direct link to a page of a particular P2P advertisement on a market. 
You can follow this link to navigate right to trader's AD




