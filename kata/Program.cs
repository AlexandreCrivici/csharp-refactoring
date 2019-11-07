using kata.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            List<Item> items = Item.SeedDatas().ToList();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    System.Console.WriteLine(items[j]);
                    items[j].UpdateQuality();
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
