using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodshop
{
    internal class Dairy : ShopItem
    {
        public Dairy(string name, double price) : base(name, price)
        {
        }

        public Dairy(string name, double price, double perservativePercentage) : base(name, price, perservativePercentage)
        {
        }
    }
}
