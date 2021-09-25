using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Crypto
{
    public class CryptoExecution
    {
        [JsonPropertyName("effective_price")]
        public string EffectivePriceString { get; set; }
        public decimal EffectivePrice => Decimal.Parse(EffectivePriceString);

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("quantity")]
        public string QuantityString { get; set; }
        public decimal Quantity => Decimal.Parse(QuantityString);

        [JsonPropertyName("timestamp")]
        public DateTime TimeStamp { get; set; }
    }
}