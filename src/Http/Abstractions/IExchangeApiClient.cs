namespace artbit.API.Client.Http.Abstractions
{
    using Exceptions;
    using Models;
    using Models.Enums;
    using Implementations;

    public interface IExchangeApiClient
    {
        public string BaseUrl { get; }

        /// <summary>
        /// Get filtering options are available for filtering rates
        /// </summary>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ExchangeRateFilterOptions> GetFilterOptionsAsync();

        /// <summary>
        /// Get lastest rate with filters
        /// </summary>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<P2PTrade>> GetLatestExchangeRatesAsync(TradeDirectionEnum? directionQuery, string directionPath, ExchangeRateFilter body);

        /// <summary>
        /// Get the bests rate at the moment grouped by exchanges
        /// </summary>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<ExchangeRates>> GetBestRatesAsync(TradeDirectionEnum direction, ExchangeRateFilter body);
    }
}
