using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodshop
{
    internal class Shop
    {
        public List<ShopItem> stock;
        public Shop()
        {
            stock = new List<ShopItem>();
        }

        public Shop(List<ShopItem> initialStock)
        {
            stock = initialStock;
        }

        public void FillStock(ShopItem item)
        {
            stock.Add(item);
        }

        public List<string> ShowStock()
        {
            List<string> itemsInfo = new List<string>();
            foreach (var item in stock)
            {
                itemsInfo.Add($"name: {item.name}, Price: {item.price}, Freshness: {item.ConvertFreshnessToString()}, Days in Shop: {item.daysInTheShop}");
            }
            return itemsInfo;
        }

        public double GetStockValue()
        {
            double totalValue = 0;
            foreach (var item in stock)
            {
                totalValue += item.price;
            }
            return totalValue;
        }

        public void SellItems(double price, bool superHealthy)
        {
            foreach (var item in stock)
            {
                if (superHealthy && item.CalculateFreshness() == 2 && item.perservativePercentage < 2)
                {
                    Console.WriteLine($"Sold {item.name} for {item.price}");
                }
                else if (!superHealthy)
                {
                    Console.WriteLine($"Sold {item.name} for {item.price}");
                }
            }
        }
    }
}
