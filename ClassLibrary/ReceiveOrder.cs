using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    class ReceiveOrder
    {
        ItemRepository itemrepo = new ItemRepository();
        public void forfillOrders()
        {
            foreach (Order order in itemrepo.orderRepo.GetList())
            {
                if (order.CompletionTracker == false)
                {
                    foreach (Item item in itemrepo.GetList())
                    {
                        if (order.ItemOrdered.Name == item.Name)
                        {
                            item.IncAmount(order.BoughtAmount);
                            order.CompletionTracker = true;
                        }
                    }
                }
            }
        }
    }
}
