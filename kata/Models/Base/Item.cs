using kata.Models.Interface;
using kata.Models.UpdateQualityEngine;
using System.Collections.Generic;

namespace kata.Models.Base
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        protected IUpdateQualityEngine _updateQualityEngine = new NormalQualityIncrement();
        public override string ToString()
        {
            return string.Format($"{this.Name}, {this.SellIn}, {this.Quality}");
        }

        public void UpdateQuality()
        {
            this.Quality = _updateQualityEngine.UpdateQuality(this.Quality, this.SellIn);
        }

        public static IEnumerable<Item> SeedDatas()
        {
            var datas = new List<Item>{
                new NormalItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new CheeseItem {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new NormalItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
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
				// this conjured item does not work properly yet
				new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            return datas;
        }
    }
}
