using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Dairy dairyProduct = new Dairy("Milk", 2.5, 1.5);
            Dairy dairyProduc2 = new Dairy("Yogurt", 4.5, 1.5);
            Dairy dairyProduct3 = new Dairy("Cheese", 6.8, 1.5);
            Dairy dairyProduct4 = new Dairy("Butter", 3.7, 1.5);
            Vegetable vegetableProduct = new Vegetable("Carrot", 1.0);
            Vegetable vegetableProduct2 = new Vegetable("Tomato", 2.1);
            Vegetable vegetableProduct3 = new Vegetable("Garlic", 4.2);
            Vegetable vegetableProduct4 = new Vegetable("Onion", 3.4);

            Shop shop = new Shop();
            shop.FillStock(dairyProduct);
            shop.FillStock(dairyProduc2);
            shop.FillStock(dairyProduct3);
            shop.FillStock(dairyProduct4);
            shop.FillStock(vegetableProduct);
            shop.FillStock(vegetableProduct2);
            shop.FillStock(vegetableProduct3);
            shop.FillStock(vegetableProduct4);

            Console.WriteLine("Initial Stock:");
            foreach (var itemInfo in shop.ShowStock())
            {
                Console.WriteLine(itemInfo);
            }

            shop.SellItems(3.5, true);

            Console.WriteLine($"Total Stock Value: {shop.GetStockValue()}");

            // Simulate a day passing
            foreach (var item in shop.stock)
            {
                item.IncrementDaysInTheShop();
            }

            Console.WriteLine("Stock after a day:");
            foreach (var itemInfo in shop.ShowStock())
            {
                Console.WriteLine(itemInfo);
            }

            Console.ReadKey();
        }
    }
}
