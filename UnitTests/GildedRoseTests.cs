using kata;
using kata.Models.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UnitTests.MockTables;

namespace UnitTests
{
    [TestClass]
    public class GildedRoseTests
    {
        [TestMethod]
        public void GildedRose_Start_RunSuccessFull()
        {
            IEnumerable<Item> items = MockItems.GetMockItems();

            GildedRose gildedRose = new GildedRose(items);
            var itemsUpdated = gildedRose.Start();

            Assert.IsTrue(itemsUpdated.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void GildedRose_Start_RunUnSuccessFull()
        {
            IEnumerable<Item> items = null;

            GildedRose gildedRose = new GildedRose(items);
            var itemsUpdated = gildedRose.Start();
        }
    }
}
