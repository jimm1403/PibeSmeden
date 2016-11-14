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

        public void AddMultipleToInventoryList(Item[] items)
        {
            foreach (Item item in items)
            {
                itemList.Add(item);
            }
        }

        public List<Item> GetList()
        {
            return itemList;
        }
       
        public override string ToString() // does not support weight yet
        {
            string output;

            string priceS = "" + price;
            priceS = string.Format("{0:0.00}", price);
            priceS = priceS.Replace(',', '.');

            output = itemType + " " + brand + " " + brandType + " " + priceS + " ";

            if (pieces != 0)
            {
                output = output + pieces;
            }
            else if (weight != 0)
            {
                string weightS = "" + weight;
                weightS = string.Format("{0:0.00}", weight);
                weightS = weightS.Replace(',', '.');

                output = output + weightS;
            }
            else
            {
                throw new Exception("Pieces and weight are both 0");
            }

            return output;
        }

        public List<Item> SearchAndRetrive<T>(T searchTerm)
        {
            List<Item> output = new List<Item>();

            if (typeof(T) == typeof(string))
            {
                foreach (Item str in itemList)
                {
                    if (itemType.Equals(searchTerm))
                    {
                        output.Add(str);
                    }
                    else if (brand.Equals(searchTerm))
                    {
                        output.Add(str);
                    }
                    else if (brandType.Equals(searchTerm))
                    {
                        output.Add(str);
                    } 
                }
                if (output.Count == 0)
                {
                    throw new Exception("Search term did not match anything");
                }
            }
            else if (typeof(T) == typeof(int))
            {
                foreach (Item num in itemList)
                {
                    if (pieces.Equals(searchTerm))
                    {
                        output.Add(num);
                    }
                }
                if (output.Count == 0)
                {
                    throw new Exception("Search term did not match anything");
                }
            }
            else if (typeof(T) == typeof(double))
            {
                foreach (Item dec in itemList)
                {
                    if (price.Equals(searchTerm))
                    {
                        output.Add(dec);
                    }
                    else if (weight.Equals(searchTerm))
                    {
                        output.Add(dec);
                    }
                }
                if (output.Count == 0)
                {
                    throw new Exception("Search term did not match anything");
                }
            }
            else
            {
                throw new Exception("invalid item type");
            }

            return output;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            if (this == obj)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
