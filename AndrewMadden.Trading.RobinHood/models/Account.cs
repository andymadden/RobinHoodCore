using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models
{
    public class Account
    {
        [JsonPropertyName("apex_account_number")]
        public string ApexAccountNumber { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("rhs_account_number")]
        public int RhsAccountNumber { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("status_reason_code")]
        public string StatusReasonCode { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}