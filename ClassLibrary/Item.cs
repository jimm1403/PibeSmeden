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
        bool warnignToogle;
        int warningThreshold;

        public string Category
        {
            get { return category; }
            set
            {
                if (value.Length != 0)
                {
                    category = value;
                }
                else
                {
                    throw new Exception("Catagory can not be empty");
                }; }
            }
        public string Brand
        {
            get { return brand; }
            set
            {
                if (value.Length != 0)
                {
                    brand = value;
                }
                else
                {
                    throw new Exception("Brand can not be empty");
                }; }
            }
        public string BrandType
        {
            get { return brandType; }
            set
            {
                if (value.Length != 0)
                {
                    brandType = value;
                }
                else
                {
                    throw new Exception("Brand Type can not be empty");
                }; }
            }
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("Amount in storage can not be lower then zero");
                }; }
            }
        public int Pieces
        {
            get { return pieces; }
            set
            {
                if (value > 0 )
                {
                    pieces = value;
                }
                else
                {
                    throw new Exception("There can not be zero pieces or lower");
                }; }
            }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0.00)
                {
                    weight = value;
                }
                else
                {
                    throw new Exception("It can not weight zero or below");
                }; }
            }
        public string WarningToogle
        {
            get
            {
                if (warnignToogle == true)
                {
                    return "On";
                }
                else if (warnignToogle == false)
                {
                    return "Off";
                }
                else
                {
                    throw new Exception("How did a bool become something other then true/false?");
                }; }
            set
            {
                if (value == "On" || value == "on")
                {
                    warnignToogle = true;
                }
                else if (value == "Off" || value == "off")
                {
                    warnignToogle = false;
                }
                else
                {
                    throw new Exception("Only On/Off is valid inputs - case insensitive");
                }; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0.00)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("It can not cost zero or lower");
                }
            }
        }
        public int WarningThreshold
        {
            get { return warningThreshold; }
            set
            {
                if (value > 0)
                {
                    warningThreshold = value;
                }
                else
                {
                    throw new Exception("Warning threshold can not be zero or lower");
                }; }
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
        public void IncAmount()
        {
            Amount++;
        }
        public void DecAmount()
        {
            if (Amount != 0)
            {
                Amount--;
            }
            else
            {
                throw new Exception("Can't go below zero");
            }
        }
    }
}

