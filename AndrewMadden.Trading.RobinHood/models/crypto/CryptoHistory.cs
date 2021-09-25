using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Crypto
{
    public class CryptoHistory
    {
        [JsonPropertyName("data_points")]
        public CryptoHistorical[] DataPoints { get; set; }

        [JsonPropertyName("bounds")]
        public string Bounds { get; set; }

        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("span")]
        public string Span { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("open_price")]
        public string OpenPriceString { get; set; }
        public decimal OpenPrice => Decimal.Parse(OpenPriceString);

        [JsonPropertyName("open_time")]
        public DateTime OpenTime { get; set; }

        [JsonPropertyName("previous_close_price")]
        public string PreviousClosePriceString { get; set; }
        public decimal PreviousClosePrice => Decimal.Parse(PreviousClosePriceString);

        [JsonPropertyName("previous_close_time")]
        public DateTime PreviousCloseTime { get; set; }
    }
}