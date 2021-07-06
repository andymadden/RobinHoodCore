using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Stocks
{
    public class StockHistory
    {
        [JsonPropertyName("quote")]
        public string Quote { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("span")]
        public string Span { get; set; }

        [JsonPropertyName("bounds")]
        public string Bounds { get; set; }

        [JsonPropertyName("previous_close_price")]
        public string PreviousClosePrice { get; set; }

        [JsonPropertyName("previous_close_time")]
        public DateTime PreviousCloseTime { get; set; }

        [JsonPropertyName("open_price")]
        public string OpenPrice { get; set; }

        [JsonPropertyName("open_time")]
        public DateTime OpenTime { get; set; }

        [JsonPropertyName("instrument")]
        public string Instrument { get; set; }

        [JsonPropertyName("historicals")]
        public StockHistorical[] Historicals { get; set; }
    }
}