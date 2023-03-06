namespace artbit.ExchangeRate.API.Client.Abstractions
{
    using Implementations;

    public interface IExchangeRateApiClient
    {
        /// <summary>
        /// Get lastest rate with filters
        /// </summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<P2PTradeModel>> LatestAsync(TradeDirectionEnum? directionQuery, string directionPath, P2PTradeFilterModel body);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<ValueTuple_2OfExchangeEnumAndIEnumerable_1OfP2PTradeModel>> BestAsync(TradeDirectionEnum? directionQuery, string directionPath, P2PTradeFilterModel body);
    }
}
