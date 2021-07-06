using System;
using AndrewMadden.Trading.RobinHood.Models;

namespace AndrewMadden.Trading.RobinHood.Connectors.Stocks
{
    public class StockConnector
    {
        public RobinHttpClient Client;

        public StockHistoryGatherer Histories;
        public StockQuoteGatherer Quotes;
        
        public StockConnector(RobinHttpClient Client)
        {
            this.Client = Client;

            this.Histories = new StockHistoryGatherer(this.Client);
            this.Quotes = new StockQuoteGatherer(this.Client);
        }
    }
}