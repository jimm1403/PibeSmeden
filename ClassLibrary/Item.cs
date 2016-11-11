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

        public List<Item> GetList()
        {
            return itemList;
        }
       
        public override string ToString() // does not support weight yet
        {
            string retstring;

            string priceDec;
            priceDec = string.Format("{0:0.00}", price);
            string[] priceUSA = priceDec.Split(',');

            string priceUS = priceUSA[0] + "." + priceUSA[1];
           
            retstring = itemType + " " + brand + " " + brandType + " " + priceUS + " " + pieces; 

            return retstring;
        }
    }
}
