using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft_Carrier
{
    internal class Carrier
    {
        List<F16> aircrafts = new List<F16>();
        public int storedAmmo;

        public int hp;

        public Carrier(int hp, int storedAmmo)
        {
            this.hp = hp;
            this.storedAmmo = storedAmmo;
        }

        public void add(F16 aircraft) { aircrafts.Add(aircraft); }

        public void fill()
        {
            try
            {
                if (storedAmmo == 0)
                {
                    throw new InvalidOperationException();
                }
                List<F16> needAmmoAircrafts = new List<F16>();
                int needed = 0;
                foreach (var aircraft in aircrafts)
                {
                    if (aircraft.maxAmmo - aircraft.currentAmmo != 0)
                    {
                        needed += aircraft.maxAmmo - aircraft.currentAmmo;
                        needAmmoAircrafts.Add(aircraft);
                    }
                }

                if (needed > storedAmmo)
                {
                    for (int i = 0; i < needAmmoAircrafts.Count; i++)
                    {
                        if (storedAmmo > 11)
                        {

                            if (needAmmoAircrafts[i].isPriority())
                            {
                                storedAmmo -= 12 - needAmmoAircrafts[i].refillAmmo(12);
                            }
                            else
                            {
                                storedAmmo -= 12 - needAmmoAircrafts[i].refillAmmo(8);
                            }
                        }
                    }
                }
                else
                {
                    foreach (var aircraft in needAmmoAircrafts)
                    {
                        storedAmmo -= aircraft.refillAmmo(aircraft.maxAmmo);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void fight(Carrier carrier)
        {
            int allDamage = 0;
            foreach (var aircraft in aircrafts)
            {
                allDamage += aircraft.fight();
            }
            carrier.hp -= allDamage;
        }


        public string getStatus()
        {
            if (hp <= 0)
            {
                return "Its dead Jim :(";
            }
            string status = $"Hp : {hp}, Aircraft count: {aircrafts.Count}, Ammo storage: {storedAmmo}\n";

            foreach (var item in aircrafts)
            {
                status += item.getStatus() + "\n";
                Console.WriteLine(status);
            }

            return status;
        }
    }
}
