using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ItemRepository
    {
        List<Item> inventoryList = new List<Item>();

        public void AddToInventoryList(Item item)
        {
            inventoryList.Add(item);
        }
        public void AddMultipleToInventoryList(List<Item> items)
        {
            inventoryList.AddRange(items);
        }
        public List<Item> GetList()
        {
            return inventoryList;
        }

        public void RemoveFromInventoryList(int index)
        {
            if (index <= inventoryList.Count)
            {
                inventoryList.RemoveAt(index);
            }
            else
            {
                throw new Exception("Tried to remove an Item that does not exist in the list");
            }

        }

        public List<Item> Search(string searchTerm)
        {
            List<Item> output = new List<Item>();

            foreach (Item item in inventoryList)
            {
                if (item.ToStringItem().Contains(searchTerm))
                {
                    output.Add(item);
                }
            }
            if (output.Count == 0)
            {
                throw new Exception("Search term did not match anything");
            }
            return output;
        }
    }
}
