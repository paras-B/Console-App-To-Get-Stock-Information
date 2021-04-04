using System;
using System.Text.Json.Serialization;

namespace ConsoleAppStockPriceGetter
{
    public class QuoteLookUpSymbol
    {
        [JsonPropertyName("c")]
        public float c { get; set; }

        [JsonPropertyName("h")]
        public float h { get; set; }

        [JsonPropertyName("l")]
        public float l { get; set; }

        [JsonPropertyName("o")]
        public float o { get; set; }

        [JsonPropertyName("pc")]
        public float pc { get; set; }

        [JsonPropertyName("t")]
        public int t { get; set; }
    }

}
