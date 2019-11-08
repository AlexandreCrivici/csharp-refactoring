using kata.Models;
using kata.Models.Base;
using System.Collections.Generic;

namespace UnitTests.MockTables
{
    public static class MockItems
    {
        public static IEnumerable<Item> GetMockItems()
        {
            var datas = new List<Item>{
                new NormalItem {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new CheeseItem {
                    Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                },
                new NormalItem {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                },
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
                },
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new ConjuredItem {
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                }
            };

            return datas;
        }

        public static IEnumerable<Item> GetNormalItems()
        {
            var datas = new List<Item>{
                new NormalItem {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new NormalItem {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
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

        public static IEnumerable<Item> GetConjuredItems()
        {
            var datas = new List<Item>{
                new ConjuredItem {
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                },
                new ConjuredItem {
                    Name = "Conjured  2 Mana Cake",
                    SellIn = 4,
                    Quality = 10
                }
            };

            return datas;
        }

        public static IEnumerable<Item> GetBackStageItems()
        {
            var datas = new List<Item>{
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackStageItem
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                }
            };

            return datas;
        }
    }
}
