using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;
using System.Configuration;
using AndrewMadden.Trading.RobinHood;
using AndrewMadden.Trading.RobinHood.Models;
using Microsoft.VisualBasic;

namespace AndrewMadden.Trading.ConsoleApp
{
    class Program
    {

        static async Task Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("token");
                string token = sr.ReadToEnd();
                RobinHttpClient rhc = new RobinHttpClient(token);
                Quote q = await rhc.Stocks.Quotes.getQuote("AMD");
                Console.WriteLine(q.AskPrice);
            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read:");
                Console.WriteLine(e.Message);
            }
        }

    }
}
