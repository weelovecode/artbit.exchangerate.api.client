using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace artbit.API.Client.Http.Models
{
    [GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ExchangeRateFilter
    {
        [JsonProperty("banks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> Banks { get; set; } = new int[0];

        [JsonProperty("exchanges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> Exchanges { get; set; } = new int[0];

        [JsonProperty("cryptoAssets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> CryptoAssets { get; set; } = new int[0];

        [JsonProperty("fiatAsset", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int FiatAsset { get; set; }
    }
}
