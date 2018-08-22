using System;
using System.Collections.Generic;

namespace csharpTuples
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<(string name, int quantity, double cost)> transactions = new List<(string, int, double)>();

            (string name, int quantity, double cost) transaction1 = ("Hammers", 5, 12);
            (string name, int quantity, double cost) transaction2 = ("Axe", 23, 7.50);
            (string name, int quantity, double cost) transaction3 = ("Saw", 12, 18);
            (string name, int quantity, double cost) transaction4 = ("Lumber", 2, 5);
            (string name, int quantity, double cost) transaction5 = ("Screws", 6, 0.50);

            transactions.Add(transaction1);
            transactions.Add(transaction2);
            transactions.Add(transaction3);
            transactions.Add(transaction4);
            transactions.Add(transaction5);
            // transactions.AddRange();

            int itemsSold = 0;
            double moneyMade = 0;

            foreach ((string name, int quantity, double cost) item in transactions)
            {
                itemsSold += item.quantity;
                moneyMade += (item.quantity * item.cost);
            }

            Console.WriteLine($"You sold {itemsSold} items today!");
            Console.WriteLine($"You Made {moneyMade} dollars today!");



            // List<(string name, int quantity, double cost)> transactionsAll = AddMany(transactions, transaction1, transaction2, transaction3, transaction4, transaction5);

        }

        // public static List<(string name, int quantity, double cost)> AddMany<T>(this List<T> list, params T[] elements)
        //   {
        //     return list.AddRange(elements);
        //   }
    }
}
