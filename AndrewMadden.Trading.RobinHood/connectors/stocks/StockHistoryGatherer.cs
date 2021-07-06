using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Models.Stocks;
using AndrewMadden.Trading.RobinHood;

namespace AndrewMadden.Trading.RobinHood.Connectors.Stocks
{
    public class StockHistoryGatherer
    {
        private RobinHttpClient Client;
        
        public StockHistoryGatherer(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<StockHistory> getDayHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=trading&include_inactive=true&interval=5minute&span=day");
            var history = await JsonSerializer.DeserializeAsync<StockHistory>(await streamTask);

            return history;
        }

        public async Task<StockHistory> getWeekHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=10minute&span=week");
            var history = await JsonSerializer.DeserializeAsync<StockHistory>(await streamTask);

            return history;
        }

        public async Task<StockHistory> getMonthHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=hour&span=month");
            var history = await JsonSerializer.DeserializeAsync<StockHistory>(await streamTask);

            return history;
        }

        public async Task<StockHistory> getQuarterHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=day&span=3month");
            var history = await JsonSerializer.DeserializeAsync<StockHistory>(await streamTask);

            return history;
        }

        public async Task<StockHistory> getYearHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=day&span=year");
            var history = await JsonSerializer.DeserializeAsync<StockHistory>(await streamTask);

            return history;
        }

        public async Task<StockHistory> getFiveYearHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=day&span=5year");
            var history = await JsonSerializer.DeserializeAsync<StockHistory>(await streamTask);

            return history;
        }
    }
}