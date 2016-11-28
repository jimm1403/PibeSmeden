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
        //ændre her under
        List<Item> itemList;
        Item dummy = new Item("Dummy", "Dummy", 0.01, 0.01, 0, 1);
        Item cigaret1 = new Item("Cigaretter", "Prince", 44.00, 30.00, 200);
        Item cigaret2 = new Item("Cigaretter", "Kings", 41.00, 27.00 , 200);
        Item roegTobak1 = new Item("Tobak", "Home Roll", 85.95, 71.95, 100, 62.00);
        Item roegTobak2 = new Item("Tobak", "Escort", 113.95, 99.95, 100, 73.00);
        ItemRepository itemRepo = new ItemRepository();
        //
        [TestInitialize()]
        public void Initialize()
        {
            itemRepo.ClearList();
        }

        [TestMethod]
        public void CanAddNewItemToList()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            Assert.AreEqual(1, itemList.Count);
        }
        [TestMethod]
        public void CanAddMultipleItemsToList()
        {
            List<Item> items = new List<Item>() { cigaret1, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSeeTheItemInListWithPieces()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Cigaretter, Prince, 44.00 DKK, 30.00 DKK, 200 Stk", itemList[0].ToStringItem());

        }
        [TestMethod]
        public void CanSeeTheItemInListWithWeight()
        {
            itemRepo.AddToInventoryList(roegTobak1);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Tobak, Home Roll, 85.95 DKK, 71.95 DKK, 100 Stk, 62.00 g", itemList[0].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithPieces()
        {
            List<Item> items = new List<Item>() { cigaret1, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Cigaretter, Prince, 44.00 DKK, 30.00 DKK, 200 Stk", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter, Kings, 41.00 DKK, 27.00 DKK, 200 Stk", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeight()
        {
            List<Item> items = new List<Item>() { roegTobak1, roegTobak2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Tobak, Home Roll, 85.95 DKK, 71.95 DKK, 100 Stk, 62.00 g", itemList[0].ToStringItem());
            Assert.AreEqual("Tobak, Escort, 113.95 DKK, 99.95 DKK, 100 Stk, 73.00 g", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeightAndPieces()
        {
            List<Item> items = new List<Item>() { roegTobak1, cigaret1 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Tobak, Home Roll, 85.95 DKK, 71.95 DKK, 100 Stk, 62.00 g", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter, Prince, 44.00 DKK, 30.00 DKK, 200 Stk", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingAString()
        {
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.Search("Cigaretter");

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingAInt()
        {
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.Search("20");

            Assert.AreEqual(2, itemList.Count);
        }
        [TestMethod]
        public void CanSearchAndRetriveNewListWithHitsUsingADouble()
        {
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
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            itemRepo.RemoveFromInventoryList(1);

            Assert.AreEqual(3, itemList.Count);
        }
        [TestMethod]
        public void CanRemoveAnItemFromTheListAndStillSeeTheOthers()
        {
            List<Item> items = new List<Item>() { roegTobak1, cigaret1, roegTobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            itemRepo.RemoveFromInventoryList(1);

            Assert.AreEqual("Tobak, Home Roll, 85.95 DKK, 71.95 DKK, 100 Stk, 62.00 g", itemList[0].ToStringItem());
            Assert.AreEqual("Tobak, Escort, 113.95 DKK, 99.95 DKK, 100 Stk, 73.00 g", itemList[1].ToStringItem());
            Assert.AreEqual("Cigaretter, Kings, 41.00 DKK, 27.00 DKK, 200 Stk", itemList[2].ToStringItem());
        }
        [TestMethod]
        public void CanReceiveAWarningWhenItemIsLow()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].Amount = 12;
            itemList[0].WarningToogle = "On";
            itemList[0].WarningThreshold = 15;

            Assert.AreEqual("Prince Cigaretter is running low, there is only 12 left in storage.", itemRepo.Warning(itemList[0]));
        }
        [TestMethod]
        public void CanReceiveAMessageWhenAItemIsNotLow()
        {
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
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].Amount = 12;
            itemList[0].WarningToogle = "Off";
            itemList[0].WarningThreshold = 15;

            Assert.AreEqual("There is enough items in storage, or this item is not set to have a warning.", itemRepo.Warning(itemList[0]));
        }
        [TestMethod]
        public void CanIncreaseAmountBySetAmount()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].IncAmount(366);

            Assert.AreEqual(566, itemList[0].Amount);
        }
        [TestMethod]
        public void CanDecreasAmountBySetAmount()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].DecAmount(66);

            Assert.AreEqual(134, itemList[0].Amount);
        }
        [TestMethod]
        public void CanNotDecreasAmountBelowZero()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            try
            {
                itemList[0].DecAmount(666);
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
                Item test = new Item("", "Prince", 666.66, 200, 100);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithEmptyName()
        {
            try
            {
                Item test = new Item("Cigaretter", "", 666.66, 444.44, 100);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithASalesPriceOfZero()
        {
            try
            {
                Item test = new Item("Cigaretter", "Prince", 0.00, 444.44, 100);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotMakeNewItemWithAMarketPriceOfZero()
        {
            try
            {
                Item test = new Item("Cigaretter", "Prince", 666.66, 0.00, 200);
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
                Item test = new Item("Cigaretter", "Prince", 666.66, 444.44, 200, 0.00);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]
        public void CanNotSetWarningThresholdToZeroOrLess()
        {
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


