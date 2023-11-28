using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodshop
{
    internal class ShopItem
    {
        public string name;
        public double price;

        public double perservativePercentage;
        public int daysInTheShop;

        public ShopItem(string name, double price)
        {
            this.name = name;
            this.price = price;
            daysInTheShop = 0;
        }

        public ShopItem(string name, double price, double perservativePercentage)
        {
            this.name = name;
            this.price = price;
            this.perservativePercentage = perservativePercentage;
            daysInTheShop = 0;
        }

        public int CalculateFreshness()
        {
            if (this is Dairy dairy)
            {
                if (daysInTheShop > 5) return 0;
                if (daysInTheShop > 3) return 1;
                return 2;
            }
            else if (this is Vegetable vegetable)
            {
                if (daysInTheShop > 3) return 0;
                if (daysInTheShop > 1) return 1;
                return 2;
            }
            else
            {
                throw new InvalidOperationException("Unknown ShopItem type.");
            }
        }

        public void Reduceprice()
        {
            int freshness = CalculateFreshness();
            switch (freshness)
            {
                case 0:
                    price *= 0.5; // 50% reduction for freshness 0
                    break;
                case 1:
                    if (this is Dairy)
                    {
                        price *= 0.7; // 30% reduction for dairy products with freshness 1
                    }
                    else if (this is Vegetable)
                    {
                        price *= 0.8; // 20% reduction for vegetable products with freshness 1
                    }
                    break;
            }
            Console.WriteLine($"price reduced. New price: {price}");
        }


        public string ConvertFreshnessToString()
        {
            int freshness = CalculateFreshness();
            switch (freshness)
            {
                case 0:
                    return "bad";
                case 1:
                    return "ok";
                case 2:
                    return "good";
                default:
                    throw new InvalidOperationException("Unexpected freshness value.");
            }
        }

        public void IncrementDaysInTheShop()
        {
            daysInTheShop++;
        }


    }
}
