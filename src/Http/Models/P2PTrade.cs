namespace artbit.API.Client.Http.Models
{
    using Enums;
    using Newtonsoft.Json;
    using System.CodeDom.Compiler;

    [GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class P2PTrade
    {
        [JsonProperty("dateUtc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateUtc { get; set; }

        [JsonProperty("traderId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TraderId { get; set; } = "";

        [JsonProperty("trader", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Trader { get; set; } = "";

        [JsonProperty("ordersAmount", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int OrdersAmount { get; set; }

        [JsonProperty("completedOrdersPercent", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double CompletedOrdersPercent { get; set; }

        [JsonProperty("availableAmount", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double AvailableAmount { get; set; }

        [JsonProperty("price", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double Price { get; set; }

        [JsonProperty("banks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int> Banks { get; set; } = new int[0];

        [JsonProperty("exchange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int Exchange { get; set; }

        [JsonProperty("direction", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TradeDirectionEnum Direction { get; set; }

        [JsonProperty("minAmount", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double MinAmount { get; set; }

        [JsonProperty("maxAmount", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double MaxAmount { get; set; }

        [JsonProperty("platformCommission", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double PlatformCommission { get; set; }

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; } = "";
    }
}
