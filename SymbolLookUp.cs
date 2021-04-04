using System.Text.Json.Serialization;

namespace ConsoleAppStockPriceGetter
{
    public class SymbolLookUp
    {
        [JsonPropertyName("count")]
        public int count { get; set; }

        [JsonPropertyName("result")]
        public SymbolLookUpResult[] result { get; set; }
    }

    public class SymbolLookUpResult
    {
        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("displaySymbol")]
        public string displaySymbol { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }
    }
}

