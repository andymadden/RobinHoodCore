using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models
{
    public class Order
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("ref_id")]
        public string RefId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("cancel")]
        public string Cancel { get; set; }

        [JsonPropertyName("instrument")]
        public string Instrument { get; set; }

        [JsonPropertyName("instrument_id")]
        public string InstrumentId { get; set; }

        [JsonPropertyName("cumulative_quantity")]
        public string CumulativeQuantityString { get; set; }
        public decimal CumulativeQuantity => Decimal.Parse(CumulativeQuantityString);

        [JsonPropertyName("average_price")]
        public string AveragePriceString { get; set; }
        public decimal AveragePrice => Decimal.Parse(AveragePriceString);

        [JsonPropertyName("fees")]
        public string FeesString { get; set; }
        public decimal Fees => Decimal.Parse(FeesString);

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("pending_cancel_open_agent")]
        public bool PendingCancelOpenAgent { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("time_in_force")]
        public string TimeInForce { get; set; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; set; }

        [JsonPropertyName("price")]
        public string PriceString { get; set; }
        public decimal Price => Decimal.Parse(PriceString);

        [JsonPropertyName("stop_price")]
        public string StopPriceString { get; set; }
        public decimal StopPrice => Decimal.Parse(StopPriceString);

        [JsonPropertyName("quantity")]
        public string QuantityString { get; set; }
        public decimal Quantity => Decimal.Parse(QuantityString);

        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("last_transaction_at")]
        public DateTime LastTransactionAt { get; set; }

        [JsonPropertyName("extended_hours")]
        public bool ExtendedHours { get; set; }

        [JsonPropertyName("override_dtbp_checks")]
        public bool OverrideDtbpChecks { get; set; }

        [JsonPropertyName("override_day_trade_checks")]
        public bool OverrideDayTradeChecks { get; set; }
    }
}