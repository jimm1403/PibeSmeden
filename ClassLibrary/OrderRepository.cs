using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class OrderRepository
    {
        public static List<Order> orderList = new List<Order>();
        
        public Order FindOrderById(int id)
        {
            Order foundOrder = orderList[0];
            int i = 0;
            bool found = false;

            while (i < orderList.Count && !found)
            {
                if (orderList[i].GetId() == id)
                {
                    foundOrder = orderList[i];
                }
            }

            return foundOrder;
        }
        public Order FindNewestOrder()
        {
            Order foundOrder = orderList[0];
            int i = 0;
            bool found = false;

            while (i < orderList.Count && !found)
            {
                if (orderList.Count == i)
                {
                    foundOrder = orderList[i];
                    found = true;

                }
                i++;
            }
            return foundOrder;
        }

        public List<Order> GetList()
        {
            return orderList;
        }
        public void ClearList()
        {
            orderList.Clear();
        }
        public void AddAOrderToList(Order order)
        {
            if (order.CompletionTracker == false)
            {
                orderList.Add(order);
            }
            else
            {
                throw new Exception("No need to add a order that is marked as already complet");
            }
        }
        public void AddMultipleOrdersToList(List<Order> orders)
        {
            int markedComplete = 0;

            foreach (Order order in orders)
            {
                if (true)
                {
                    if (order.CompletionTracker == false)
                    {
                        orderList.Add(order);
                    }
                    else
                    {
                        markedComplete++;
                    }
                }
            }
            if (markedComplete > 0)
            {
                throw new Exception("No need to add orders that is marked as already complet, " + markedComplete + " Orders skipped");
            }
        }
        /*public List<Order> searchOrder(string searchterm)
        {
            List<Order> output = new List<Order>();

            string searchtermlow = searchterm.ToLower();

            foreach (Order order in orderList)
            {
                if (order.ToStringOrder().ToLower().Contains(searchtermlow))
                {
                    output.Add(order);
                }
            }
            if (output.Count == 0)
            {
                throw new Exception("search term did not match anything");
            }
            return output;
        }*/
    }
}
