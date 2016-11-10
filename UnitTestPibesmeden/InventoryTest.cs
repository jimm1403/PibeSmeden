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
            Item myItem = new Item();

            myItem.AddToInventoryList("Cigaretter", "Prince", "Light", 44.00, 20);

            itemList = myItem.GetList();

            Assert.AreEqual(1, itemList.Count);
        }
        [TestMethod]
        public void CanSeeTheItemInList()
        {
            Item myItem = new Item();

            myItem.AddToInventoryList("Cigaretter", "Prince", "Light", 44.00, 20);

            itemList = myItem.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToString());

        }
    }
}
