namespace artbit.ExchangeRate.API.Client
{
    using Abstractions;
    using Implementations;
    using Microsoft.Extensions.DependencyInjection;

    public static class ExchangeRateApiClientExt
    {
        readonly static string HttpClientName = nameof(ExchangeRateApiClient);

        public static void RegisterExchangeRateClient(this IServiceCollection services, string exchangeRateHostBaseUrl)
        {
            if (string.IsNullOrEmpty(exchangeRateHostBaseUrl))
            {
                throw new ArgumentNullException(nameof(exchangeRateHostBaseUrl), $"Url of {nameof(exchangeRateHostBaseUrl)} was not provided");
            }

            services
                    .AddScoped<IExchangeRateApiClient, ExchangeRateApiClient>(_ => new ExchangeRateApiClient(exchangeRateHostBaseUrl, _.GetService<HttpClient>()));
        }

        public static HttpClient CreateExchangeRateClient(this IHttpClientFactory httpClientFactory)
        {
            return httpClientFactory.CreateClient(HttpClientName);
        }
    }
}
