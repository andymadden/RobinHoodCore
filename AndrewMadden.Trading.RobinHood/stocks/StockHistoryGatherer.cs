using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Models;
using AndrewMadden.Trading.RobinHood;

namespace AndrewMadden.Trading.RobinHood.Stocks
{
    public class StockHistoryGatherer
    {
        private RobinHttpClient Client;
        
        public StockHistoryGatherer(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<History> getDayHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=trading&include_inactive=true&interval=5minute&span=day");
            var history = await JsonSerializer.DeserializeAsync<History>(await streamTask);

            return history;
        }

        public async Task<History> getWeekHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=10minute&span=week");
            var history = await JsonSerializer.DeserializeAsync<History>(await streamTask);

            return history;
        }

        public async Task<History> getMonthHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=hour&span=month");
            var history = await JsonSerializer.DeserializeAsync<History>(await streamTask);

            return history;
        }

        public async Task<History> getQuarterHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=day&span=3month");
            var history = await JsonSerializer.DeserializeAsync<History>(await streamTask);

            return history;
        }

        public async Task<History> getYearHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=day&span=year");
            var history = await JsonSerializer.DeserializeAsync<History>(await streamTask);

            return history;
        }

        public async Task<History> getFiveYearHistory(string Symbol)
        {
            var streamTask = Client.GetStreamAsync($"https://api.robinhood.com/marketdata/historicals/{Symbol}/?bounds=regular&include_inactive=true&interval=day&span=5year");
            var history = await JsonSerializer.DeserializeAsync<History>(await streamTask);

            return history;
        }
    }
}