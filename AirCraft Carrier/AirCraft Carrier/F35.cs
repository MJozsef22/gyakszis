using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft_Carrier
{
    internal class F35 : F16
    {
        public F35() : base()
        {
            maxAmmo = 12;
            baseDMG = 50;
        }

        public override bool isPriority()
        {
            return true;
        }
    }
}
