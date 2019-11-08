using kata.Models.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.MockTables;

namespace UnitTests
{
    [TestClass]
    public class UpdateQualityTests
    {
        [TestMethod]
        public void UpdateQuality_Start_NormalItemDecreaseOneTime()
        {
            List<Item> items = MockItems.GetNormalItems()
                                        .ToList();

            for (int i = 0; i < 10; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(10, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(-5, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_NormalItemDecreaseTwiceAfterSellinPasses()
        {
            List<Item> items = MockItems.GetNormalItems()
                                        .ToList();

            for (int i = 0; i < 15; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
            Assert.AreEqual(-5, items[0].SellIn);
            Assert.AreEqual(-10, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_LegendaryItemNeverDecrease()
        {
            List<Item> items = MockItems.GetLegendaryItems()
                                        .ToList();

            for (int i = 0; i < 31; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(80, items[1].Quality);
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(-1, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_ConjuredItemDecreaseTwice()
        {
            List<Item> items = MockItems.GetConjuredItems()
                                        .ToList();

            for (int i = 0; i < 3; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(4, items[1].Quality);
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(1, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_ConjuredItemDecreaseFourTimeAfterSellInPasses()
        {
            List<Item> items = MockItems.GetConjuredItems()
                                        .ToList();

            for (int i = 0; i < 5; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
            Assert.AreEqual(-2, items[0].SellIn);
            Assert.AreEqual(-1, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_CheeseItemIncrease()
        {
            List<Item> items = MockItems.GetCheeseItems()
                                        .ToList();

            for (int i = 0; i < 2; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(2, items[0].Quality);
            Assert.AreEqual(12, items[1].Quality);
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(4, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_CheeseItemIncreaseTwiceAfterSellInPasses()
        {
            List<Item> items = MockItems.GetCheeseItems()
                                        .ToList();

            for (int i = 0; i < 11; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(20, items[0].Quality);
            Assert.AreEqual(26, items[1].Quality);
            Assert.AreEqual(-9, items[0].SellIn);
            Assert.AreEqual(-5, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_BackStageIncreaseWithSellInMoreThan10()
        {
            List<Item> items = MockItems.GetBackStageItems()
                                        .ToList();

            for (int i = 0; i < 5; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(25, items[0].Quality);
            Assert.AreEqual(50, items[1].Quality);
            Assert.AreEqual(10, items[0].SellIn);
            Assert.AreEqual(5, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_BackStageIncreaseWithSellInBetween5And10()
        {
            List<Item> items = MockItems.GetBackStageItems()
                                        .ToList();

            for (int i = 0; i < 10; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(35, items[0].Quality);
            Assert.AreEqual(50, items[1].Quality);
            Assert.AreEqual(5, items[0].SellIn);
            Assert.AreEqual(0, items[1].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_BackStageIncreaseWithSellInLessThan5()
        {
            List<Item> items = MockItems.GetBackStageItems()
                                        .ToList();

            for (int i = 0; i < 15; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
        }

        [TestMethod]
        public void UpdateQuality_Start_BackStageQualitySetToZeroWithSellInPasses()
        {
            List<Item> items = MockItems.GetBackStageItems()
                                        .ToList();

            for (int i = 0; i < 15; i++)
            {
                foreach (Item item in items)
                {
                    item.UpdateQuality();
                }
            }

            Assert.AreEqual(0, items[1].Quality);
            Assert.AreEqual(-5, items[1].SellIn);
        }


    }
}
