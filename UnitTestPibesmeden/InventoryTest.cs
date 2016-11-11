using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestPibesmeden
{
    [TestClass]
    public class InventoryTest
    {

        List<Item> itemList = new List<Item>();
        Item dummy = new Item("Dummy", "Dummy", "Dummy", 0.00, 0);
        Item cigaret1 = new Item("Cigaretter", "Prince", "Light", 44.00, 20);
        Item cigaret2 = new Item("Cigaretter", "Kings", "Blå", 41.00, 20);
        Item roegTobak1 = new Item("Røg Tobak", "Home Roll", "Menthol", 85.95, 62.00);
        Item roegTobak2 = new Item("Røg Tobak", "Escort", "White", 113.95, 73.00);

        [TestMethod]
        public void CanAddNewItemToList()
        {
            dummy.AddToInventoryList(cigaret1);

            itemList = dummy.GetList();

            Assert.AreEqual(1, itemList.Count);
        }
        [TestMethod]
        public void CanAddMultipleItemsToList()
        {
            Item[] Items = new Item[] {cigaret1, cigaret2};

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.GetList();

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSeeTheItemInListWithPieces()
        {
            dummy.AddToInventoryList(cigaret1);

            itemList = dummy.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToString());

        }
        [TestMethod]
        public void CanSeeTheItemInListWithWeight()
        {
            dummy.AddToInventoryList(roegTobak1);

            itemList = dummy.GetList();

            Assert.AreEqual("Røg Tobak Home Roll Menthol 85.95 62.00", itemList[0].ToString());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithPieces()
        {
            Item[] Items = new Item[] { cigaret1, cigaret2 };

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToString());
            Assert.AreEqual("Cigaretter Kings Blå 41.00 20", itemList[1].ToString());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeight()
        {
            Item[] Items = new Item[] { roegTobak1, roegTobak2};

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.GetList();

            Assert.AreEqual("Røg Tobak Home Roll Menthol 85.95 62.00", itemList[0].ToString());
            Assert.AreEqual("Røg Tobak Escort White 113.95 73.00", itemList[1].ToString());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeightAndPieces()
        {
            Item[] Items = new Item[] { roegTobak1, cigaret1};

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.GetList();

            Assert.AreEqual("Røg Tobak Home Roll Menthol 85.95 62.00", itemList[0].ToString());
            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[1].ToString());
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingAString()
        {
            Item[] Items = new Item[] { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.SearchAndRetrive("Cigaretter");

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingAInt()
        {
            Item[] Items = new Item[] { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.SearchAndRetrive(20);

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingADouble()
        {
            Item[] Items = new Item[] { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            dummy.AddMultipleToInventoryList(Items);

            itemList = dummy.SearchAndRetrive(73.00);

            Assert.AreEqual(1, itemList.Count);
        }
    }
}
