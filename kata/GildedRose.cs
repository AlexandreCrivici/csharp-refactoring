using kata.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kata
{
    public class GildedRose
    {
        private List<Item> _items;

        public GildedRose(IEnumerable<Item> items)
        {
            _items = items.ToList();
        }

        /// <summary>
        /// Start the program to update the quality depending the days
        /// </summary>
        public IEnumerable<Item> Start()
        {
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < _items.Count; j++)
                {
                    System.Console.WriteLine(_items[j]);
                    _items[j].UpdateQuality();
                }
                Console.WriteLine("");

            }

            return _items;
        }
    }
}
