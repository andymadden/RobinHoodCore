using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Stocks
{
    public class StockOrderRequest
    {
        [JsonPropertyName("account")]
        public string Account { get; set; }
        
        [JsonPropertyName("extended_hours")]
        public bool ExtendedHours { get; set; }

        [JsonPropertyName("instrument")]
        public string Instrument { get; set; }

        [JsonPropertyName("price")]
        public string PriceString { get; set; }
        public decimal Price => Decimal.Parse(PriceString);

        [JsonPropertyName("quantity")]
        public string QuantityString { get; set; }
        public decimal Quantity => Decimal.Parse(QuantityString);

        [JsonPropertyName("ref_id")]
        public string RefId { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("time_in_force")]
        public string TimeInForce { get; set; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}