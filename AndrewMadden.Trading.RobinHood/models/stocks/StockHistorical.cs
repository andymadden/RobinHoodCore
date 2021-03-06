using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Stocks
{
    public class StockHistorical
    {
        [JsonPropertyName("begins_at")]
        public DateTime BeginsAt { get; set; }

        [JsonPropertyName("open_price")]
        private string OpenPriceString { get; set; }
        public decimal OpenPrice => Decimal.Parse(OpenPriceString);

        [JsonPropertyName("close_price")]
        private string ClosePriceString { get; set; }
        public decimal ClosePrice => Decimal.Parse(ClosePriceString);

        [JsonPropertyName("high_price")]
        private string HighPriceString { get; set; }
        public decimal HighPrice => Decimal.Parse(HighPriceString);

        [JsonPropertyName("low_price")]
        private string LowPriceString { get; set; }
        public decimal LowPrice => Decimal.Parse(LowPriceString);

        [JsonPropertyName("volume")]
        public int Volume { get; set; }

        [JsonPropertyName("interpolated")]
        public bool Interpolated { get; set; }

    }
}