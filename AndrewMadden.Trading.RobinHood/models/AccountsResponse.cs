using System;
using System.Text.Json.Serialization;

namespace AndrewMadden.Trading.RobinHood.Models
{
    public class AccountsResponse
    {
        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        [JsonPropertyName("results")]
        public Account[] Accounts { get; set; }
    }
}