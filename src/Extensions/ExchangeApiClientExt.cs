﻿namespace artbit.API.Client
{
    using Http.Abstractions;
    using Http.Implementations;
    using Microsoft.Extensions.DependencyInjection;

    public static class ExchangeApiClientExt
    {
        readonly static string HttpClientName = nameof(ExchangeClient);

        public static IServiceCollection RegisterExchangeRateApiClient(this IServiceCollection serviceCollection, string exchangeRateHostBaseUrl)
        {
            if (string.IsNullOrEmpty(exchangeRateHostBaseUrl))
            {
                throw new ArgumentNullException(nameof(exchangeRateHostBaseUrl), $"Url of {nameof(exchangeRateHostBaseUrl)} was not provided");
            }

            serviceCollection
                    .AddScoped<IExchangeApiClient, ExchangeClient>(_ => new ExchangeClient(exchangeRateHostBaseUrl, _.GetService<HttpClient>()));

            return serviceCollection;
        }
    }
}
