using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft_Carrier
{
    internal class F16
    {
        public int maxAmmo;
        public int baseDMG;
        public int currentAmmo;

        public F16()
        {
            maxAmmo = 8;
            baseDMG = 30;
            currentAmmo = 0;
        }

        public int fight()
        {
            int totalDMG = currentAmmo * baseDMG;
            currentAmmo = 0; return totalDMG;
        }

        public int refillAmmo(int amount)
        {
            int needed = maxAmmo - currentAmmo;
            if (needed < amount)
            {
                currentAmmo = maxAmmo;
                amount -= needed;
            }
            else
            {
                currentAmmo += amount;
                amount = 0;
            }
            return amount;
        }

        public string getType()
        { return getType().ToString(); }

        public string getStatus()
        {
            return $"Type {getType()}, Ammo: {currentAmmo}, Base DMG {baseDMG}, All damage: {currentAmmo * baseDMG}";
        }

        public virtual bool isPriority()
        {
            return false;
        }
    }
}
