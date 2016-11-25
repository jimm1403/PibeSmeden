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
        Item dummy = new Item("Dummy", "Dummy", "Dummy", 0.01, 0, 1);
        Item cigaret1 = new Item("Cigaretter", "Prince", "Light", 44.00, 200, 20);
        Item cigaret2 = new Item("Cigaretter", "Kings", "Blå", 41.00, 200, 20);
        Item roegTobak1 = new Item("Røg Tobak", "Home Roll", "Menthol", 85.95, 100, 62.00);
        Item roegTobak2 = new Item("Røg Tobak", "Escort", "White", 113.95, 100, 73.00);
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

            Assert.AreEqual("Cigaretter, Prince, Light, 44.00, 200, 20", itemList[0].ToStringItem());

        }
        [TestMethod]
        public void CanSeeTheItemInListWithWeight()
        {
            itemRepo.AddToInventoryList(roegTobak1);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 100, 62.00", itemList[0].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithPieces()
        {
            List<Item> items = new List<Item>() { cigaret1, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Cigaretter, Prince, Light, 44.00, 200, 20", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter, Kings, Blå, 41.00, 200, 20", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeight()
        {
            List<Item> items = new List<Item>() { roegTobak1, roegTobak2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 100, 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Røg Tobak, Escort, White, 113.95, 100, 73.00", itemList[1].ToStringItem());
        }
        [TestMethod]
        public void CanSeeMultipleItemsInListWithWeightAndPieces()
        {
            List<Item> items = new List<Item>() { roegTobak1, cigaret1 };

            itemRepo.AddMultipleToInventoryList(items);
            itemList = itemRepo.GetList();

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 100, 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Cigaretter, Prince, Light, 44.00, 200, 20", itemList[1].ToStringItem());
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

            Assert.AreEqual("Røg Tobak, Home Roll, Menthol, 85.95, 100, 62.00", itemList[0].ToStringItem());
            Assert.AreEqual("Røg Tobak, Escort, White, 113.95, 100, 73.00", itemList[1].ToStringItem());
            Assert.AreEqual("Cigaretter, Kings, Blå, 41.00, 200, 20", itemList[2].ToStringItem());
        }
        [TestMethod]
        public void CanReceiveAWarningWhenItemIsLow()
        {
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

            itemList[0].IncAmount(3);

            Assert.AreEqual(203, itemList[0].Amount);
        }
        [TestMethod]
        public void CanDecreasAmountBySetAmount()
        {
            itemRepo.AddToInventoryList(cigaret1);
            itemList = itemRepo.GetList();

            itemList[0].DecAmount(3);

            Assert.AreEqual(197, itemList[0].Amount);
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
                Item test = new Item("", "Prince", "Light", 666.66, 200, 100 );
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
                Item test = new Item("Cigaretter", "", "Light", 666.66, 200, 100);
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
                Item test = new Item("Cigaretter", "Prince", "", 666.66, 200, 100);
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
                Item test = new Item("Cigaretter", "Prince", "Light", 0.00, 200, 100);
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
                Item test = new Item("Cigaretter", "Prince", "Light", 666.66, 200, 0);
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
                Item test = new Item("Cigaretter", "Prince", "Light", 666.66, 200, 0.00);
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


