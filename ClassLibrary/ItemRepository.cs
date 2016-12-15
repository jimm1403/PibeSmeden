using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ItemRepository
    {
        public static List<Item> inventoryList = new List<Item>();

        public OrderRepository orderRepo = new OrderRepository();


        public void AddToInventoryList(Item item)
        {
            try
            {
                if (Search(item.Name).Count > 0)
                {
                    throw new Exception("Input item already exists");
                }
            }
            catch (Exception)
            {
                inventoryList.Add(item);
            }
        }
        public void AddMultipleToInventoryList(List<Item> items)
        {
            int alreadyExisting = 0;
            int addedItemsCount = 0;

            foreach (Item item in items)
            {
                try
                {
                    if (Search(item.Name).Count > 0)
                    {
                        alreadyExisting++;
                    }
                }
                catch (Exception)
                {
                    inventoryList.Add(item);
                    addedItemsCount++;
                }
            }
            if (alreadyExisting > 0)
            {
                throw new Exception(alreadyExisting + " Input item(s) already exists, only added " + addedItemsCount + " out of a total of " + items.Count);
            }
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
        public List<Item> GetList()
        {
            return inventoryList;
        }
        public List<Item> Search(string searchTerm)
        {
            List<Item> output = new List<Item>();

            string searchTermLow = searchTerm.ToLower();

            foreach (Item item in inventoryList)
            {
                if (item.ToStringItem().ToLower().Contains(searchTermLow))
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
        public List<string> ConvertItemListToStringList()
        {
            List<string> searchLineList = new List<string>();

            foreach (Item item in inventoryList)
            {
                searchLineList.Add(item.ToStringItem());
            }

            return searchLineList;
        }
        public string Warning(Item item)
        {
            string returnstring;

            if (item.WarningToogle == "On" && item.Amount < item.WarningThreshold)
            {
                returnstring = item.Name + " " + item.Category + " is running low, there is only " + item.Amount + " left in storage.";

                return returnstring;
            }
            else
            {
                return "There is enough items in storage, or this item is not set to have a warning.";
            }
        }
        public void ClearList()
        {
            inventoryList.Clear();
        }

    }
}

