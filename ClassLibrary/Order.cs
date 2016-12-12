using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        Item itemOrdered;
        int boughtAmount;
        bool completionTracker;
        string orderDate; 


        public Item ItemOrdered { get { return itemOrdered; } set { itemOrdered = value; } }
        public int BoughtAmount { get { return boughtAmount; } set { boughtAmount = value; } }
        public bool CompletionTracker { get { return completionTracker; } set { completionTracker = value; } }
        public string OrderDate { get { return orderDate; } set { orderDate = value; } }

        public Order()
        {

        }
        public Order(Item itemOrdered, int boughtAmount)
        {
            ItemOrdered = itemOrdered;
            BoughtAmount = boughtAmount;
            CompletionTracker = false;
        }

        public string ToStringOrder()
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
        }
    }
}
