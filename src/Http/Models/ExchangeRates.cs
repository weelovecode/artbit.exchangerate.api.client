using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace artbit.API.Client.Http.Models
{
    [GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ExchangeRates
    {
        [JsonProperty("exchange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int Exchange { get; set; }

        [JsonProperty("rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<P2PTrade> Rates { get; set; } = new P2PTrade[0];

    }
}
