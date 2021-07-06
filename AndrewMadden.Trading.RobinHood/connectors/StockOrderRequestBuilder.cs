using System;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Models.Stocks;

namespace AndrewMadden.Trading.RobinHood.Connectors
{
    public class StockOrderRequestBuilder
    {
        private RobinHttpClient Client;

        public StockOrderRequestBuilder(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<StockOrderRequest> CreateLimitBuyRequest(string symbol, decimal limitPrice, int quantity, string timeInForce)
        {
            string instrument;
            if (Client.Instruments.ContainsKey(symbol)) {
                instrument = Client.Instruments[symbol];
            } else {
                var quote = await Client.Stocks.Quotes.getQuote(symbol);
                Client.Instruments.Add(symbol, quote.Instrument);
                instrument = quote.Instrument;
            }
            return new StockOrderRequest {
                Account = $"https://api.robinhood.com/accounts/{Client.AccountId}/",
                ExtendedHours = false,
                Instrument = instrument,
                PriceString = limitPrice.ToString("C2"),
                QuantityString = quantity.ToString(),
                RefId = Guid.NewGuid().ToString(),
                Side = "buy",
                Symbol = symbol,
                TimeInForce = timeInForce,
                Trigger = "immediate",
                Type = "limit"
            };
        }

        public async Task<StockOrderRequest> CreateLimitSellRequest(string symbol, decimal limitPrice, int quantity, string timeInForce)
        {
            string instrument;
            if (Client.Instruments.ContainsKey(symbol)) {
                instrument = Client.Instruments[symbol];
            } else {
                var quote = await Client.Stocks.Quotes.getQuote(symbol);
                Client.Instruments.Add(symbol, quote.Instrument);
                instrument = quote.Instrument;
            }
            return new StockOrderRequest {
                Account = $"https://api.robinhood.com/accounts/{Client.AccountId}/",
                ExtendedHours = false,
                Instrument = instrument,
                PriceString = limitPrice.ToString("C2"),
                QuantityString = quantity.ToString(),
                RefId = Guid.NewGuid().ToString(),
                Side = "sell",
                Symbol = symbol,
                TimeInForce = timeInForce,
                Trigger = "immediate",
                Type = "limit"
            };
        }
    }
}