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

        List<Item> itemList;
        Item dummy = new Item("Dummy", "Dummy", "Dummy", 0.00, 0);
        Item cigaret1 = new Item("Cigaretter", "Prince", "Light", 44.00, 20);
        Item cigaret2 = new Item("Cigaretter", "Kings", "Blå", 41.00, 20);
        Item roegTobak1 = new Item("Røg Tobak", "Home Roll", "Menthol", 85.95, 62.00);
        Item roegTobak2 = new Item("Røg Tobak", "Escort", "White", 113.95, 73.00);

        [TestMethod]
        public void CanAddNewItemToList()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            Assert.AreEqual(1, itemList.Count);
        }
        [TestMethod]
        public void CanAddMultipleItemsToList()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { cigaret1, cigaret2};

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSeeTheItemInListWithPieces()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToStringItem());

        }
        [TestMethod]
        public void CanSeeTheItemInListWithWeight()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(roegTobak1);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak Home Roll Menthol 85.95 62.00", itemList[0].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithPieces()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { cigaret1, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter Kings Blå 41.00 20", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeight()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, roegTobak2};

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak Home Roll Menthol 85.95 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Røg Tobak Escort White 113.95 73.00", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeightAndPieces()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1};

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak Home Roll Menthol 85.95 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingAString()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.Search("Cigaretter");

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingAInt()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.Search("20");

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingADouble()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.Search("73.00");

            Assert.AreEqual(1, itemList.Count);
        }
    }
}
