using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Item
    {
        public string category;
        public string name;
        public double salesPrice;
        public string salesPriceS;
        public double marketPrice;
        public string marketPriceS;
        public double weight;
        public string weightS;
        public int amount;
        bool warnignToogle;
        int warningThreshold;
        int warningCountdown;

        public string Category
        {
            get { return category; }
            set
            {
                if (value == null)
                {
                    value = "";
                }
                if (value.Length != 0)
                {
                    category = value;
                }
                else
                {
                    throw new Exception("Catagory can not be empty");
                }; }
            }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    value = "";
                }
                if (value.Length != 0)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name can not be empty");
                };
            }
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
        public double SalesPrice
        {
            get { return salesPrice; }
            set
            {
                if (value > 0.00)
                {
                    salesPrice = value;
                }
                else
                {
                    throw new Exception("It can not cost zero or lower");
                }
            }
        }
        public double MarketPrice
        {
            get { return marketPrice; }
            set
            {
                if (value > 0.00)
                {
                    marketPrice = value;
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
        public int WarningCountdown
        {
            get { return warningCountdown; }
            set { warningCountdown = value; }
        }

        public Item()
        {

        }
        public Item(string category, string name, double salesPrice, double marketPrice, int amount)
        {
            Category = category;
            Name = name;
            SalesPrice = salesPrice;
            MarketPrice = marketPrice;
            Amount = amount;
        }
        public Item(string category, string name, double salesPrice, double marketPrice, int amount, double weight)
        {
            Category = category;
            Name = name;
            SalesPrice = salesPrice;
            MarketPrice = marketPrice;
            Amount = amount;
            Weight = weight;
        }
        public string ToStringItem()
        {
            string output;

            salesPriceS = "" + salesPrice;
            salesPriceS = string.Format("{0:0.00}", salesPrice);
            salesPriceS = salesPriceS.Replace(',', '.');

            marketPriceS = "" + marketPrice;
            marketPriceS = string.Format("{0:0.00}", marketPrice);
            marketPriceS = marketPriceS.Replace(',', '.');

            output = category + ", " + name + ", " + salesPriceS + " DKK, " + marketPriceS + " DKK, " + amount + " Stk";


            if (weight != 0)
            {
                weightS = "" + weight;
                weightS = string.Format("{0:0.00}", weight);
                weightS = weightS.Replace(',', '.');

                output = output + ", " + weightS + " g";
            }

            warningCountdown = amount - warningThreshold;

            if (warningCountdown <= 0)
            {
                output = output + " - LAV BEHOLDNING!";
            }

            return output;
        }
        public void IncAmount(int incAmount)
        {
            amount += incAmount;
        }
        public void DecAmount(int decAmount)
        {
            if (amount >= decAmount)
            {
                amount -= decAmount;
            }
            else
            {
                throw new Exception("Can't go below zero");
            }
        }
    }
}

