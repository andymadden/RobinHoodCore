using System;
using AndrewMadden.Trading.RobinHood.Models;

namespace AndrewMadden.Trading.RobinHood.Stocks
{
    public class StockInterface
    {
        public RobinHttpClient Client;

        public StockHistoryGatherer Histories;
        public StockQuoteGatherer Quotes;
        
        public StockInterface(RobinHttpClient Client)
        {
            this.Client = Client;

            this.Histories = new StockHistoryGatherer(this.Client);
            this.Quotes = new StockQuoteGatherer(this.Client);
        }
    }
}