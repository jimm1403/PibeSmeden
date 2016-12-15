using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class OrderLine
    {
        int quantity;
        Item orderLineItem;

        public OrderLine(int quantity, Item item)
        {
            this.quantity = quantity;
            orderLineItem = item;
        }

        


    }
}
