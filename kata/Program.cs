using kata.Models.Base;
using System;
using System.Collections.Generic;

namespace kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            IEnumerable<Item> items = Item.SeedDatas();

            GildedRose gildedRose = new GildedRose(items);
            gildedRose.Start();

            Console.ReadLine();
        }
    }
}
