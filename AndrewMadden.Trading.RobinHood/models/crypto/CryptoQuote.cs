using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Crypto
{
    public class CryptoQuote
    {
        [JsonPropertyName("ask_price")]
        public string AskPriceString { get; set; }
        public decimal AskPrice => Decimal.Parse(AskPriceString);

        [JsonPropertyName("bid_price")]
        public string BidPriceString { get; set; }
        public decimal BidPrice => Decimal.Parse(BidPriceString);

        [JsonPropertyName("mark_price")]
        public string MarkPriceString { get; set; }
        public decimal MarkPrice => Decimal.Parse(MarkPriceString);

        [JsonPropertyName("high_price")]
        public string HighPriceString { get; set; }
        public decimal HighPrice => Decimal.Parse(HighPriceString);

        [JsonPropertyName("low_price")]
        public string LowPriceString { get; set; }
        public decimal LowPrice => Decimal.Parse(LowPriceString);

        [JsonPropertyName("open_price")]
        public string OpenPriceString { get; set; }
        public decimal OpenPrice => Decimal.Parse(OpenPriceString);

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("volume")]
        public string VolumeString { get; set; }
        public decimal Volume => Decimal.Parse(VolumeString);

    }
}