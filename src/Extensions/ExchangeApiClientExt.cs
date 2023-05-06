namespace artbit.API.Client
{
    using Http.Abstractions;
    using Http.Implementations;
    using Microsoft.Extensions.DependencyInjection;

    public static class ExchangeApiClientExt
    {
        readonly static string HttpClientName = nameof(ExchangeClient);

        /// <summary>
        /// Register IExchangeApiClient implementation and dependencies
        /// </summary>
        public static IServiceCollection RegisterExchangeRateApiClient(this IServiceCollection serviceCollection, string? exchangeRateHostBaseUrl = null)
        {
            if (string.IsNullOrEmpty(exchangeRateHostBaseUrl))
            {
                exchangeRateHostBaseUrl = "https://ex.artbit.one";
            }

            serviceCollection
                    .AddHttpClient();

            serviceCollection
                    .AddScoped<IExchangeApiClient, ExchangeClient>(_ => new ExchangeClient(exchangeRateHostBaseUrl, _.GetService<HttpClient>()));

            return serviceCollection;
        }
    }
}
