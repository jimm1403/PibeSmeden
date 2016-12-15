using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        static int nextid = 1;
        int orderId;
        bool completionTracker = false;
        string orderDate;
        public List<OrderLine> orderLineList;
        
        public bool CompletionTracker
        {
            get { return completionTracker; }
            set { completionTracker = value; }
        }
        public string OrderDate 
        { 
            get { return orderDate; } 
            set { orderDate = value; } 
        }

        public string isOrderDone()
        {
            string completion = "";
            completionTracker = CompletionTracker;
            if (completionTracker)
            {
                completion = "Modtaget";
            }
            else
            {
                completion = "Ikke modtaget";
            }

            return completion;
        }

        public Order()
        {

        }
        public Order(string orderDate)
        {
            completionTracker = false;
            OrderDate = orderDate;
            orderId = nextid++;
            orderLineList = new List<OrderLine>();
        }

        public void addItemsToOrderLine(OrderLine orderLine)
        {
            orderLineList.Add(orderLine);
        }
        public int GetId()
        {
            return orderId;
        }
        /*public string ToStringOrder()
        {
            string output;

            output = ItemOrdered.ToStringItem();

            if (ItemOrdered.WarningCountdown <= 0)
            {
                output = output.Substring(0, output.Length - 18);
            }

            output = output + ", Vil gerne have " + BoughtAmount + " Stk";

            if (CompletionTracker == false)
            {
                output = output + ", Order er ikke blevet modtaget";
            }
            else
            {
                output = output + ", Order er blevet modtaget";
            }
            return output;
        }*/
    }
}
