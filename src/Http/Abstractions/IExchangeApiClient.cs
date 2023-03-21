namespace artbit.API.Client.Http.Abstractions
{
    using Implementations;

    public interface IExchangeApiClient
    {
        /// <summary>
        /// Get filters are available for filtering rates
        /// </summary>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<ExchangeRateFilter>> ExchangeAsync();

        /// <summary>
        /// Get lastest rate with filters
        /// </summary>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<P2PTrade>> LatestAsync(TradeDirectionEnum? directionQuery, string directionPath, P2PTradeFilter body);

        /// <summary>
        /// Get the bests rate at the moment grouped by exchanges
        /// </summary>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<ExchangeRates>> BestRatesAsync(TradeDirectionEnum direction, P2PTradeFilter body);
    }
}
