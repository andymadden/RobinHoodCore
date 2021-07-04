using System;
using System.Text.Json;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Models;

namespace AndrewMadden.Trading.RobinHood.Stocks
{
    public class StockQuoteGatherer
    {
        private RobinHttpClient Client;

        public StockQuoteGatherer(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<Quote> getQuote(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/quotes/{Symbol}/");
            var quote = await JsonSerializer.DeserializeAsync<Quote>(await streamTask);

            return quote;
        }
    }
}