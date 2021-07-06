using System;
using System.Threading.Tasks;
using System.Text.Json;
using AndrewMadden.Trading.RobinHood.Models;
using System.Net.Http.Json;
using Microsoft.VisualBasic;

namespace AndrewMadden.Trading.RobinHood.Stocks
{
    public class StockTradeInterface
    {
        private RobinHttpClient Client;

        public StockTradeInterface(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<Order> MakeLimitOrder()
        {
            var orderData = new OrderRequest {
                Account = $"https://api.robinhood.com/accounts/{Client.AccountId}/"
            };
            var res = await Client.PostAsJsonAsync<OrderRequest>("", orderData);
            var order = await JsonSerializer.DeserializeAsync<Order>(await res.Content.ReadAsStreamAsync());
            return order;
        }

    }
}