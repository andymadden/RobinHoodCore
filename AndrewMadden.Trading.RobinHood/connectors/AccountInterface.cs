using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AndrewMadden.Trading.RobinHood.Models;

namespace AndrewMadden.Trading.RobinHood.Connectors
{
    public class AccountInterface
    {
        public RobinHttpClient Client;

        public AccountInterface(RobinHttpClient Client)
        {
            this.Client = Client;
        }

        public async Task<Account> GetAccount()
        {
            Task<Stream> streamTask = Client.GetStreamAsync("https://nummus.robinhood.com/accounts/");
            AccountsResponse accounts = await JsonSerializer.DeserializeAsync<AccountsResponse>(await streamTask);

            if (accounts.Accounts.Length > 0) {
                return accounts.Accounts[0];
            } else {
                return null;
            }
        }
    }
}