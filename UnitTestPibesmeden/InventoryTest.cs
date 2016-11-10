using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

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
    }
}
