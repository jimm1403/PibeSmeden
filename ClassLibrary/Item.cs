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

        //public string ItemType
        //{
        //    get { return itemType; }
        //    set { itemType = value; }
        //}
        //public string Brand
        //{
        //    get { return brand; }
        //    set { brand = value; }
        //}
        //public string BrandType
        //{
        //    get { return brandType; }
        //    set { brandType = value; }
        //}
        //public double Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}
        //public double Weight
        //{
        //    get { return weight; }
        //    set { weight = value; }
        //}
        //public int Pieces
        //{
        //    get { return pieces; }
        //    set { pieces = value; }
        //}

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

        public void AddToInventoryList()
        {
            itemList.Add();
        }
        public List<Item> GetList()
        {
            return itemList;
        }

    }
}
