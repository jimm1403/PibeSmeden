using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Item
    {
        List<Item> itemList = new List<Item>();
        string itemType;
        string brand;
        string brandType;
        double price;
        double weight;
        int pieces;

        public Item()
        {

        }
        public Item(string _itemType, string _brand, string _brandType, double _price, int _pieces)
        {
            itemType = _itemType;
            brand = _brand;
            brandType = _brandType;
            price = _price;
            pieces = _pieces;
        }
        public Item(string _itemType, string _brand, string _brandType, double _price, double _weight)
        {
            itemType = _itemType;
            brand = _brand;
            brandType = _brandType;
            price = _price;
            weight = _weight;
        }

        public void AddToInventoryList(Item item)
        {
            itemList.Add(item);
        }
        public string GetList()
        {
            Item myItem = new Item("lol", "lol", "lol", 44, 20);
            string tempItem = "";

            tempItem = myItem.ToString();
            //foreach (Item item in itemList)
            //{
            //    tempItem = item.ToString();
            //}

            return tempItem;
        }

        public override string ToString()
        {
            return itemType + " - " + brand + " - " + brandType + " - " + price + " - " + pieces;
        }

    }
}
