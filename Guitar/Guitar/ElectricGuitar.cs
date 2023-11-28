using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    internal class ElectricGuitar : Guitar
    {
        protected int numberOfPickups;
        public ElectricGuitar(string brand, int numberOfStrings) : base(brand, numberOfStrings)
        {
            bodyform = form.SUPERSTRAT;
            bridgeType = bridge.FLOATING;
            price = 350.15;
            numberOfPickups = 2;
        }

        public ElectricGuitar(string brand, int numberOfStrings, bool leftHanded, form bodyform, bridge bridgeType, double price, int stringDurability) : base(brand, numberOfStrings, leftHanded, bodyform, bridgeType, price, stringDurability)
        {
            this.numberOfPickups = numberOfPickups;
        }
    }
}
