using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pirates_of_the_Carabien
{
    public class Pirates
    {
        private int intoxicationLevel;
        private bool isAlive = true;
        private Parrot parrot;

        public int GetIntoxicationLevel() { return intoxicationLevel; }

        public bool IsAlive() { return isAlive; }
        public Pirates(Parrot parrot)
        {
            this.parrot = parrot;
        }

        public void DrinkSomeRum()
        {
            if (isAlive)
            {
                intoxicationLevel++;
            }
            else
            {
                Console.WriteLine("He's dead.");
            }
        }

        public void HowsItGoingMate()
        {
            if (isAlive)
            {
                if (intoxicationLevel < 4)
                {
                    Console.WriteLine("Pour me anudder!");
                }
                else
                {
                    Console.WriteLine("Arghh,I'ma Pirate.How d'ya d'ink ist goin?");
                    PassOut();
                }
            }
            else
            {
                Console.WriteLine("He's dead.");
            }
        }

        private void PassOut()
        {
            intoxicationLevel = 0;
        }

        public void Brawl(Pirates otherPirate)
        {
            if (isAlive && otherPirate.isAlive)
            {
                Random random = new Random();
                int result = random.Next(0, 3);

                switch (result)
                {
                    case 0:
                        Die();
                        break;
                    case 1:
                        otherPirate.Die();
                        break;
                    case 2:
                        PassOut();
                        otherPirate.PassOut();
                        break;
                        //default:
                }
            }
            else
            {
                Console.WriteLine("He's dead.");
            }
        }

        public void Die()
        {
            isAlive = false;
            Console.WriteLine("He's dead.");
        }
    }

    public class Parrot
    {
        public void Speak(string message)
        {
            Console.WriteLine($"Parrot says: {message}");
        }
    }
    public class Ship
    {
        private List<Pirates> crew;
        private Pirates captain;

        public Ship()
        {
            crew = new List<Pirates>();
        }

        public void FillShip()
        {
            Random random = new Random();
            captain = new Pirates(new Parrot());
            int numPirates = random.Next(1, 114); // Random number of pirates (1 to 113)
            for (int i = 0; i < numPirates; i++)
            {
                crew.Add(new Pirates(new Parrot()));
            }
        }

        public int CalculateScore()
        {
            int alivePirates = 0;
            foreach (var pirate in crew)
            {
                if (pirate.IsAlive())
                {
                    alivePirates++;
                }
            }

            return alivePirates - captain.GetIntoxicationLevel();
        }

        public void Battle(Ship otherShip)
        {
            int thisShipScore = CalculateScore();
            int otherShipScore = otherShip.CalculateScore();

            if (thisShipScore > otherShipScore)
            {
                Console.WriteLine("This ship wins!");

                // Party time!
                captain.DrinkSomeRum();
                foreach (var pirate in crew)
                {
                    pirate.DrinkSomeRum();
                }

                int losses = new Random().Next(1, 11); // Random number of losses (1 to 10)
                for (int i = 0; i < losses; i++)
                {
                    int randomIndex = new Random().Next(0, otherShip.crew.Count);
                    otherShip.crew[randomIndex].Die();
                }
            }
            else
            {
                Console.WriteLine("Other ship wins!");

                // Party time for the other ship!
                otherShip.captain.DrinkSomeRum();
                foreach (var pirate in otherShip.crew)
                {
                    pirate.DrinkSomeRum();
                }

                int losses = new Random().Next(1, 11); // Random number of losses (1 to 10)
                for (int i = 0; i < losses; i++)
                {
                    int randomIndex = new Random().Next(0, crew.Count);
                    crew[randomIndex].Die();
                }
            }
        }

        public void DisplayShipStatus()
        {
            Console.WriteLine($"Captain Rum Level: {captain.GetIntoxicationLevel()}");
            Console.WriteLine($"Number of Alive Pirates in Crew: {crew.Count(pirate => pirate.IsAlive())}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Ship ship1 = new Ship();
                ship1.FillShip();

                Ship ship2 = new Ship();
                ship2.FillShip();

                Console.WriteLine("Ship 1 Status:");
                ship1.DisplayShipStatus();
                Console.WriteLine("\nShip 2 Status:");
                ship2.DisplayShipStatus();

                Console.WriteLine("\nLet the battle begin!");
                ship1.Battle(ship2);

                Console.WriteLine("\nShip 1 Status After Battle:");
                ship1.DisplayShipStatus();
                Console.WriteLine("\nShip 2 Status After Battle:");
                ship2.DisplayShipStatus();


                Console.ReadKey();

            }
        }
    }
}
