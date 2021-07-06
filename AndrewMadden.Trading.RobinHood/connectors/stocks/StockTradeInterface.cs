using System;
using System.Threading.Tasks;
using System.Text.Json;
using AndrewMadden.Trading.RobinHood.Models.Stocks;
using System.Net.Http.Json;
using Microsoft.VisualBasic;
using System.Collections.Concurrent;
using System.IO;
using System.Diagnostics.Tracing;

namespace AndrewMadden.Trading.RobinHood.Connectors.Stocks
{
    public class StockTrader
    {
        private RobinHttpClient Client;

        public StockTrader(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<StockOrder> MakeOrder(StockOrderRequest orderRequest)
        {
            var res = await Client.PostAsJsonAsync<StockOrderRequest>("", orderRequest);
            var order = await JsonSerializer.DeserializeAsync<StockOrder>(await res.Content.ReadAsStreamAsync());
            return order;
        }

        public async Task<StockOrder> CancelOrder(StockOrder order)
        {
            var res = await Client.PostAsJsonAsync<StockOrder>($"https://api.robinhood.com/orders/{order.Id}/cancel/", null);
            if (res.IsSuccessStatusCode) {
                return order;
            } else {
                return null;
            }
        }

    }
}