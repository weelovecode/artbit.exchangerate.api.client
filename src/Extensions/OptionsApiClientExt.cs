namespace artbit.API.Client
{
    using Http.Abstractions;
    using Http.Implementations;
    using Microsoft.Extensions.DependencyInjection;

    public static class OptionsApiClientExt
    {
        readonly static string HttpClientName = nameof(OptionsClient);

        public static IServiceCollection RegisterOptionsApiClient(this IServiceCollection serviceCollection, string exchangeRateHostBaseUrl)
        {
            if (string.IsNullOrEmpty(exchangeRateHostBaseUrl))
            {
                throw new ArgumentNullException(nameof(exchangeRateHostBaseUrl), $"Url of {nameof(exchangeRateHostBaseUrl)} was not provided");
            }

            serviceCollection.AddScoped<IOptionsApiClient, OptionsClient>(_ => new OptionsClient(exchangeRateHostBaseUrl, _.GetService<HttpClient>()));

            return serviceCollection;
        }

        public static HttpClient CreateExchangeRateClient(this IHttpClientFactory httpClientFactory)
        {
            return httpClientFactory.CreateClient(HttpClientName);
        }
    }
}
