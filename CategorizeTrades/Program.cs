using CategorizeTrades.Categories;
using CategorizeTrades.Trades;
using System;
using System.Collections.Generic;

namespace CategorizeTrades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITrade> portfolio;
            List<string> categoriesTrade;

            Trade trade1 = new Trade { Value = 2000000, ClientSector = "PRIVATE", NextPaymentDate = new DateTime(2025, 12, 29)};
            Trade trade2 = new Trade { Value = 400000, ClientSector = "PUBLIC", NextPaymentDate = new DateTime(2020, 07, 01) };
            Trade trade3 = new Trade { Value = 5000000, ClientSector = "PUBLIC", NextPaymentDate = new DateTime(2024, 01, 02) };
            Trade trade4 = new Trade { Value = 3000000, ClientSector = "PUBLIC", NextPaymentDate = new DateTime(2023, 10, 26) };

            portfolio = new List<ITrade> { trade1, trade2, trade3, trade4 };

            categoriesTrade = new Category(portfolio).GetCategories();

            Console.WriteLine("Output\n");
            Console.WriteLine($"{portfolio.Count} lines with the category of each one of the {categoriesTrade.Count} trades\n");

            Console.WriteLine("Sample input\n");
            Console.WriteLine("12/11/2020");
            Console.WriteLine($"{portfolio.Count}");

            foreach (ITrade trade in portfolio)
            {
                Console.WriteLine($"{(Trade)trade} {trade.Value} {trade.ClientSector} {trade.NextPaymentDate.ToString("MM/dd/yyyy")}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sample output\n");
            Console.WriteLine($"{categoriesTrade[0]}");
            Console.WriteLine($"{categoriesTrade[1]}");
            Console.WriteLine($"{categoriesTrade[2]}");
            Console.WriteLine($"{categoriesTrade[3]}");

            Console.ReadKey();


        }
    }
}
