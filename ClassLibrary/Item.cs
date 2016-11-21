using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Item
    {
        string category;
        string brand;
        string brandType;
        double price;
        double weight;
        int pieces;
        int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int Pieces
        {
            get { return pieces; }
            set { pieces = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Item()
        {

        }
        public Item(string category, string brand, string brandType, double price, int pieces)
        {
            this.category = category;
            this.brand = brand;
            this.brandType = brandType;
            this.price = price;
            this.pieces = pieces;
        }
        public Item(string category, string brand, string brandType, double price, double weight)
        {
            this.category = category;
            this.brand = brand;
            this.brandType = brandType;
            this.price = price;
            this.weight = weight;
        }
        public string ToStringItem()
        {
            string output;

            string priceS = "" + price;
            priceS = string.Format("{0:0.00}", price);
            priceS = priceS.Replace(',', '.');

            output = category + ", " + brand + ", " + brandType + ", " + priceS + ", ";

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
