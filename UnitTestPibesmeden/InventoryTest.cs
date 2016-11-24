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

        [TestInitialize()]
        public void Initialize()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.ClearList();
        }

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
            List<Item> items = new List<Item>() { cigaret1, cigaret2 };

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

            Assert.AreEqual("Cigaretter, Prince, Light, 44.00, 20", itemList[0].ToStringItem());

        }
        [TestMethod]
        public void CanSeeTheItemInListWithWeight()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(roegTobak1);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 62.00", itemList[0].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithPieces()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { cigaret1, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Cigaretter, Prince, Light, 44.00, 20", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter, Kings, Blå, 41.00, 20", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeight()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, roegTobak2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Røg Tobak, Escort, White, 113.95, 73.00", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeightAndPieces()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter, Prince, Light, 44.00, 20", itemList[1].ToStringItem());
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
        [TestMethod]
        public void CanSetAmountOfItemInInventory()
        {
            cigaret1.Amount = 50;

            Assert.AreEqual(50, cigaret1.Amount);
        }
        [TestMethod]
        public void CanRemoveAnItemFromTheList()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            itemRepo.RemoveFromInventoryList(1);

            Assert.AreEqual(3, itemList.Count);
        }
        [TestMethod]
        public void CanRemoveAnItemFromTheListAndStillSeeTheOthers()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            itemRepo.RemoveFromInventoryList(1);

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Røg Tobak, Escort, White, 113.95, 73.00", itemList[1].ToStringItem());
            Assert.AreEqual("Cigaretter, Kings, Blå, 41.00, 20", itemList[2].ToStringItem());
        }
        [TestMethod]
        public void CanReceiveAWarningWhenItemIsLow()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].Amount = 12;
            itemList[0].WarningToogle = "On";
            itemList[0].WarningThreshold = 15;

            Assert.AreEqual("Prince Light Cigaretter is running low, there is only 12 left in storage.", itemRepo.Warning(itemList[0]));
        }
        [TestMethod]
        public void CanReceiveAMessageWhenAItemIsNotLow()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].Amount = 12;
            itemList[0].WarningToogle = "On";
            itemList[0].WarningThreshold = 10;

            Assert.AreEqual("There is enough items in storage, or this item is not set to have a warning.", itemRepo.Warning(itemList[0]));
        }
        [TestMethod]
        public void CanReceiveAMessageWhenAItemIsNotSetupToWarn()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].Amount = 12;
            itemList[0].WarningToogle = "Off";
            itemList[0].WarningThreshold = 15;

            Assert.AreEqual("There is enough items in storage, or this item is not set to have a warning.", itemRepo.Warning(itemList[0]));
        }
        [TestMethod]
        public void CanIncreaseAmountOneByOne()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            for (int i = 0; i < 3; i++)
            {
                itemList[0].IncAmount();
            }

            Assert.AreEqual(3, itemList[0].Amount);
        }
        [TestMethod]
        public void CanDecreasAmountOneByOne()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].Amount = 6;

            for (int i = 0; i < 3; i++)
            {
                itemList[0].DecAmount();
            }

            Assert.AreEqual(3, itemList[0].Amount);
        }
        [TestMethod]
        public void CanNotDecreasAmountOneWhenAmountIsZero()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            try
            {
                itemList[0].DecAmount();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithEmptyCatagory()
        {
            try
            {
                Item test = new Item("", "Prince", "Light", 666.66, 100 );
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithEmptyBrand()
        {
            try
            {
                Item test = new Item("Cigaretter", "", "Light", 666.66, 100);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithEmptyBrandType()
        {
            try
            {
                Item test = new Item("Cigaretter", "Prince", "", 666.66, 100);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithAPriceOfZero()
        {
            try
            {
                Item test = new Item("Cigaretter", "Prince", "Light", 0.00, 100);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithZeroPieces()
        {
            try
            {
                Item test = new Item("Cigaretter", "Prince", "Light", 666.66, 0);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithZeroWeight()
        {
            try
            {
                Item test = new Item("Cigaretter", "Prince", "Light", 666.66, 0.00);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotSetWarningThresholdToZeroOrLess()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            try
            {
                itemList[0].WarningThreshold = 0;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotSetAmountToLessThenZero()
        {
            ItemRepository itemRepo = new ItemRepository();

            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            try
            {
                itemList[0].Amount = -1;
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
    }
}


