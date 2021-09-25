using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models.Crypto
{
    public class CryptoOrderRequest
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get ; set; }

        [JsonPropertyName("average_price")]
        public string AveragePriceString { get; set; }
        public decimal AveragePrice => Decimal.Parse(AveragePriceString);

        [JsonPropertyName("cancel_url")]
        public string CancelURL { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("cumulative_quantity")]
        public string CumulativeQuantityString { get; set; }
        public decimal CumulativeQuantity => Decimal.Parse(CumulativeQuantityString);

        [JsonPropertyName("currency_pair_id")]
        public string CurrencyPairId { get; set; }

        [JsonPropertyName("entered_price")]
        public string EnteredPriceString { get; set; }
        public decimal EnteredPrice => Decimal.Parse(EnteredPriceString);

        [JsonPropertyName("executions")]
        public CryptoExecution[] Executions { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("initiator_id")]
        public string InitiatorId { get; set; }

        [JsonPropertyName("initiator_type")]
        public string InitiatorType { get; set; }

        [JsonPropertyName("last_transaction_at")]
        public DateTime LastTransactionAt { get; set; }

        [JsonPropertyName("price")]
        public string PriceString { get; set; }
        public decimal Price => Decimal.Parse(PriceString);

        [JsonPropertyName("quantity")]
        public string QuantityString { get; set; }
        public decimal Quantity => Decimal.Parse(QuantityString);

        [JsonPropertyName("ref_id")]
        public string RefId { get; set; }

        [JsonPropertyName("rounded_executed_notional")]
        public string RoundedExecutedNotionalString { get; set; }
        public decimal RoundedExecutedNotional => Decimal.Parse(RoundedExecutedNotionalString);

        [JsonPropertyName("side")]
        public string Side { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("time_in_force")]
        public string TimeInForce { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}