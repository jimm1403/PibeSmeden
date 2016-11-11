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
        public void CanSeeTheItemInList()
        {
            dummy.AddToInventoryList(cigaret1);

            itemList = dummy.GetList();

            Assert.AreEqual("Cigaretter Prince Light 44.00 20", itemList[0].ToString());

        }
    }
}
