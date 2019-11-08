using kata.Models.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.MockTables;

namespace UnitTests
{
    [TestClass]
    public class MinQualityValueTests
    {
        [TestMethod]
        public void UpdateQuality_Start_NormalItem()
        {
            List<Item> items = MockItemsMinimalValue.GetNormalItems()
                                        .ToList();

            for (int i = 0; i < 100; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
        }

        [TestMethod]
        public void UpdateQuality_Start_LegendaryItem()
        {
            List<Item> items = MockItemsMinimalValue.GetLegendaryItems()
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
        public void UpdateQuality_Start_ConjuredItem()
        {
            List<Item> items = MockItemsMinimalValue.GetConjuredItems()
                                        .ToList();

            for (int i = 0; i < 100; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
        }

        [TestMethod]
        public void UpdateQuality_Start_BackStageItem()
        {
            List<Item> items = MockItemsMinimalValue.GetBackStageItems()
                                        .ToList();

            for (int i = 0; i < 100; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
        }
    }
}
