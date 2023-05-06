namespace artbit.API.Client.Http.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Options
    {
        [Newtonsoft.Json.JsonProperty("banks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Bank> Banks { get; set; } = new System.Collections.Generic.List<Bank>();

        [Newtonsoft.Json.JsonProperty("cryptoAssets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyValuePair> CryptoAssets { get; set; } = new System.Collections.Generic.List<KeyValuePair>();

        [Newtonsoft.Json.JsonProperty("fiatAssets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyValuePair> FiatAssets { get; set; } = new System.Collections.Generic.List<KeyValuePair>();

        [Newtonsoft.Json.JsonProperty("exchanges", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyValuePair> Exchanges { get; set; } = new System.Collections.Generic.List<KeyValuePair>();

        [Newtonsoft.Json.JsonProperty("refreshDelays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyValuePair> RefreshDelays { get; set; } = new System.Collections.Generic.List<KeyValuePair>();

        [Newtonsoft.Json.JsonProperty("tradeStrategies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeyValuePair> TradeStrategies { get; set; } = new System.Collections.Generic.List<KeyValuePair>();
    }
}
