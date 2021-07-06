using System;
using System.Threading.Tasks;
using System.Text.Json;
using AndrewMadden.Trading.RobinHood.Models.Stocks;
using System.Net.Http.Json;
using Microsoft.VisualBasic;

namespace AndrewMadden.Trading.RobinHood.Connectors.Stocks
{
    public class StockTrader
    {
        private RobinHttpClient Client;

        public StockTrader(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<StockOrder> MakeLimitOrder()
        {
            var orderData = new StockOrderRequest {
                Account = $"https://api.robinhood.com/accounts/{Client.AccountId}/"
            };
            var res = await Client.PostAsJsonAsync<StockOrderRequest>("", orderData);
            var order = await JsonSerializer.DeserializeAsync<StockOrder>(await res.Content.ReadAsStreamAsync());
            return order;
        }

    }
}