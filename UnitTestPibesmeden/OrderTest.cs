using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestPibesmeden
{
    [TestClass]
    public class OrderTest
    {
        
        //ændre her under
        List<Order> orderlist;
        List<Item> itemlist;

        static Item dummyItem = new Item("Dummy", "Dummy", 0.01, 0.01, 0, 1);
        static Item cigaret1 = new Item("Cigaretter", "Prince", 44.00, 30.00, 200);
        static Item cigaret2 = new Item("Cigaretter", "Kings", 41.00, 27.00, 200);
        static Item tobak1 = new Item("Tobak", "Home Roll", 85.95, 71.95, 100, 62.00);
        static Item tobak2 = new Item("Tobak", "Escort", 113.95, 99.95, 100, 73.00);

        Order dummyOrder = new Order(dummyItem, 666);
        Order restockCigaret1 = new Order(cigaret1, 150);
        Order restockCigaret2 = new Order(cigaret2, 100);
        Order restockTobak1 = new Order(tobak1, 50);
        Order restockTobak2 = new Order(tobak2, 25);

        ItemRepository itemRepo = new ItemRepository();
        ReceiveOrder recOrder = new ReceiveOrder();
        //

        [TestInitialize()]
        public void Initialize()
        {

            itemRepo.ClearList();
            itemRepo.orderRepo.ClearList();
        }

        [TestMethod]
        public void CanAddAOrderToTheList()
        {
            itemRepo.orderRepo.AddAOrderToList(restockCigaret1);

            orderlist = itemRepo.orderRepo.GetList();

            Assert.AreEqual(1, orderlist.Count);
        }
        [TestMethod]
        public void CanAddMultipleOrdersToTheList()
        {
            List<Order> orders = new List<Order>() { restockCigaret1, restockCigaret2, restockTobak1, restockTobak2 };

            itemRepo.orderRepo.AddMultipleOrdersToList(orders);

            orderlist = itemRepo.orderRepo.GetList();

            Assert.AreEqual(4, orderlist.Count);
        }
        [TestMethod]
        public void CanReceiveOrder()
        {
            List<Order> orders = new List<Order>() { restockCigaret1, restockCigaret2, restockTobak1, restockTobak2 };
            List<Item> items = new List<Item>() { tobak1, cigaret1, tobak2, cigaret2 };

            itemRepo.AddMultipleToInventoryList(items);
            itemRepo.orderRepo.AddMultipleOrdersToList(orders);

            recOrder.forfillOrders();

            itemlist = itemRepo.GetList();

            Assert.AreEqual(350, itemlist[0].Amount);
            Assert.AreEqual(300, itemlist[1].Amount);
            Assert.AreEqual(150, itemlist[2].Amount);
            Assert.AreEqual(125, itemlist[3].Amount);
        }
    }
}
