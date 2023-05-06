using Newtonsoft.Json;

namespace artbit.API.Client.Http.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Bank
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; } = "";

        [Newtonsoft.Json.JsonProperty("fiatAsset", Required = Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FiatAsset FiatAsset { get; set; } = new();

        [Newtonsoft.Json.JsonProperty("origin", Required = Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Bank? Origin { get; set; }
    }
}
