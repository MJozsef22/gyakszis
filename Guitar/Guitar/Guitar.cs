using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    enum bridge { FLOATING, FIXED };
    enum form { STRAT, SUPERSTRAT, TELE, LES_PAUL, SG, FLYING_V };
    internal class Guitar
    {
        protected string type;
        protected string brand;
        protected int numberOfStrings;
        protected bool leftHanded;
        protected form bodyform;
        //protected int numberOfPickups;
        protected bridge bridgeType;
        protected double price;

        protected int stringDurability = 100;
        protected bool inTune = true;

        public Guitar(string brand, int numberOfStrings, bool leftHanded, form bodyform,
            bridge bridgeType, double price, int stringDurability)
        {
            type = GetType().Name;
            this.brand = brand;
            this.numberOfStrings = numberOfStrings;
            this.leftHanded = leftHanded;
            this.bodyform = bodyform;
            this.bridgeType = bridgeType;
            this.price = price;
            this.stringDurability = stringDurability;
        }

        public Guitar(string brand, int numberOfStrings)
        {
            type = GetType().Name;
            this.brand = brand;
            this.numberOfStrings = numberOfStrings;
            leftHanded = false;
            bodyform = form.LES_PAUL;
            bridgeType = bridge.FIXED;
            price = 225.99;
        }

        public void play()
        {
            if (stringDurability >= 5)
            {
                Console.WriteLine("You play the guitar.");
                stringDurability -= 5;
            }
            else if (stringDurability == 0) { Console.WriteLine("You need new strings"); }
            else { Console.WriteLine("You broke a string."); stringDurability = 0; }
        }

        public void changeTheStrings()
        {
            Console.WriteLine("You restring the guitar...");
            stringDurability = 100; inTune = false;
        }

        public void tuning()
        {
            Console.WriteLine("You start tuning the guitar...");
            inTune = true;
        }

        public void practiceScales()
        { Console.WriteLine("You start practicing some scales..."); play(); }

        public string typeGet()
        {
            return type;
        }

        public void useWhammyBar()
        {
            if (bridgeType == bridge.FLOATING)
            {
                if (stringDurability > 10)
                {
                    Console.WriteLine("You used the whammy bar");
                    stringDurability -= 10;
                }
                else if (stringDurability == 0)
                { }
            }
        }

        public string brandGet() { return brand; }
        public int numberOfStringsGet() { return numberOfStrings; }
        public bool leftHandedGet() { return leftHanded; }
        public form bodyformGet() { return bodyform; }
        public bridge bridgeTypeGet() { return bridgeType; }
        public double priceGet() { return price; }
    }
}
