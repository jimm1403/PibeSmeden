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

        [TestMethod]
        public void CanAddNewItemToList()
        {
            Item myItem = new Item("Cigaretter", "Prince", "Light", 44.00, 20);

            myItem.AddToInventoryList(myItem);

            itemList = myItem.GetList();

            Assert.AreEqual(1, itemList.Count);
        }
        [TestMethod]
        public void CanSeeTheItemInList()
        {
            Item myItem = new Item("Cigaretter", "Prince", "Light", 44.00, 20);

            myItem.AddToInventoryList(myItem);

            itemList = myItem.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToString());

        }
    }
}
