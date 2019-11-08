using kata.Models.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.MockTables;

namespace UnitTests
{
    [TestClass]
    public class MaxQualityValueTests
    {
        [TestMethod]
        public void UpdateQuality_Start_LegendaryItem()
        {
            List<Item> items = MockItemsMaximalValue.GetLegendaryItems()
                                        .ToList();

            for (int i = 0; i < 100; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(80, items[1].Quality);
        }

        [TestMethod]
        public void UpdateQuality_Start_BackStageItem()
        {
            List<Item> items = MockItemsMaximalValue.GetBackStageItems()
                                        .ToList();

            for (int i = 0; i < 100; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(50, items[1].Quality);
        }

        public void UpdateQuality_Start_CheeseItem()
        {
            List<Item> items = MockItemsMaximalValue.GetCheeseItems()
                                        .ToList();

            for (int i = 0; i < 100; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(50, items[1].Quality);
        }
    }
}
