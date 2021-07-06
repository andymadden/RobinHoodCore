using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Stocks
{
    public class StockQuote
    {
        [JsonPropertyName("ask_price")]
        public string AskPriceString { get; set; }
        public decimal AskPrice => Decimal.Parse(AskPriceString);

        [JsonPropertyName("ask_size")]
        public int AskSize { get; set; }

        [JsonPropertyName("bid_price")]
        public string BidPriceString { get; set; }
        public decimal BidPrice => Decimal.Parse(BidPriceString);

        [JsonPropertyName("bid_size")]
        public int BidSizeString { get; set; }

        [JsonPropertyName("last_trade_price")]
        public string LastTradePriceString { get; set; }
        public decimal LastTradePrice => Decimal.Parse(LastTradePriceString);

        [JsonPropertyName("last_extended_hours_trade_price")]
        public string LastExtendedHoursTradePriceString { get; set; }
        public decimal LastExtendedHoursTradePrice => Decimal.Parse(LastExtendedHoursTradePriceString);

        [JsonPropertyName("previous_close")]
        public string PreviousCloseString { get; set; }
        public decimal PreviousClose => Decimal.Parse(PreviousCloseString);

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("trading_halted")]
        public bool TradingHalted { get; set; }

        [JsonPropertyName("has_traded")]
        public bool HasTraded { get; set; }

        [JsonPropertyName("last_trade_price_source")]
        public string LastTradePriceSource { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("instrument")]
        public string Instrument { get; set; }

        [JsonPropertyName("instrument_id")]
        public string InstrumentId { get; set; }

        public decimal Liquidity => AskPrice - BidPrice;
    }
}