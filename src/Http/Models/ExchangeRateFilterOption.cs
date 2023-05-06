namespace artbit.API.Client.Http.Models
{
    using Newtonsoft.Json;
    using System.CodeDom.Compiler;

    [GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ExchangeRateFilterOptions
    {
        [JsonProperty("banks", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Bank> Banks { get; set; } = new Bank[0];

        [JsonProperty("exchanges", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeyValuePair<int, string>> Exchanges { get; set; } = new KeyValuePair<int, string>[0];

        [JsonProperty("fiatAssets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeyValuePair<int, string>> FiatAssets { get; set; } = new KeyValuePair<int, string>[0];

        [JsonProperty("cryptoAssets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeyValuePair<int, string>> CryptoAssets { get; set; } = new KeyValuePair<int, string>[0];
    }
}
