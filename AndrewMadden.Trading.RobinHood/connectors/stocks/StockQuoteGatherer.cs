using System;
using System.Text.Json;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Models.Stocks;

namespace AndrewMadden.Trading.RobinHood.Connectors.Stocks
{
    public class StockQuoteGatherer
    {
        private RobinHttpClient Client;

        public StockQuoteGatherer(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<StockQuote> getQuote(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/quotes/{Symbol}/");
            var quote = await JsonSerializer.DeserializeAsync<StockQuote>(await streamTask);

            return quote;
        }
    }
}