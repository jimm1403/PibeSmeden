using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Item
    {
        string itemType;
        string brand;
        string brandType;
        double price;
        double weight;
        int pieces;

        public Item()
        {

        }
        public Item(string itemType, string brand, string brandType, double price, int pieces)
        {
            this.itemType = itemType;
            this.brand = brand;
            this.brandType = brandType;
            this.price = price;
            this.pieces = pieces;
        }
        public Item(string itemType, string brand, string brandType, double price, double weight)
        {
            this.itemType = itemType;
            this.brand = brand;
            this.brandType = brandType;
            this.price = price;
            this.weight = weight;
        }

        public void AddMultipleToInventoryList(List<Item> items)
        {
            itemList.AddRange(items);
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
    }
}
