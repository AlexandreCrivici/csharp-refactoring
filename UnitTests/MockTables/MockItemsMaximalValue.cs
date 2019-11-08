using kata.Models;
using kata.Models.Base;
using System.Collections.Generic;

namespace UnitTests.MockTables
{
    public class MockItemsMaximalValue
    {
        public static IEnumerable<Item> GetBackStageItems()
        {
            var datas = new List<Item>{
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 100,
                    Quality = -5
                },
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 100,
                    Quality = -5
                }
            };

            return datas;
        }

        public static IEnumerable<Item> GetLegendaryItems()
        {
            var datas = new List<Item>{
                new LegendaryItem {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                },
                new LegendaryItem
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = -1,
                    Quality = 80
                }
            };

            return datas;
        }

        public static IEnumerable<Item> GetCheeseItems()
        {
            var datas = new List<Item>{
                new CheeseItem {
                    Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                },
                new CheeseItem {
                    Name = "Aged Brie",
                    SellIn = 6,
                    Quality = 10
                },
            };

            return datas;
        }
    }
}
