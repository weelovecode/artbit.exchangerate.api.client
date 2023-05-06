using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace artbit.API.Client.Http.Internal.Models
{
    [GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    internal class ProblemDetails
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        [JsonProperty("instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Instance { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}
