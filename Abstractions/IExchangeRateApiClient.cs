namespace artbit.ExchangeRate.API.Client.Abstractions
{
    using Implementations;

    public interface IExchangeRateApiClient
    {
        Task<ICollection<P2PTradeModel>> BestAsync(int? tradeDirection, string direction, P2PTradeFilterModel body);
        Task<ICollection<P2PTradeModel>> BestAsync(int? tradeDirection, string direction, P2PTradeFilterModel body, CancellationToken cancellationToken);
    }
}
