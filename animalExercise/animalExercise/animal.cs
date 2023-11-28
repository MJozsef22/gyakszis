using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace animalExercise
{
    internal class animal
    {
        public int hunger;
        public int thirst;

        public animal()
        {
            hunger = 50;
            thirst = 50;
        }

        public void eat()
        {
            hunger--;
        }

        public void drink()
        {
            thirst--;
        }

        public void play()
        { hunger++; thirst++; }
    }
}
