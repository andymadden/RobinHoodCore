using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Connectors;
using AndrewMadden.Trading.RobinHood.Connectors.Stocks;
using AndrewMadden.Trading.RobinHood.Models;

namespace AndrewMadden.Trading.RobinHood
{
    public class RobinHttpClient : HttpClient
    {

        public string AccountId;

        public StockConnector Stocks;

        public RobinHttpClient(string Token)
        {
            this.DefaultRequestHeaders.Clear();
            this.DefaultRequestHeaders.Add("Host", "api.robinhood.com");
            this.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64; rv:88.0) Gecko/20100101 Firefox/88.0");
            this.DefaultRequestHeaders.Add("Accept", "*/*");
            this.DefaultRequestHeaders.Add("Accept-Language", "en-UW,en;q=0.5");
            this.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            this.DefaultRequestHeaders.Add("Referer", "https://robinhood.com");
            this.DefaultRequestHeaders.Add("Authorization", Token);
            this.DefaultRequestHeaders.Add("Origin", "https://robinhood.com");
            this.DefaultRequestHeaders.Add("DNT", "1");
            this.DefaultRequestHeaders.Add("Connection", "keep-alive");
            this.DefaultRequestHeaders.Add("TE", "Trailers");

            this.Stocks = new StockConnector(this);
        }

    }
}