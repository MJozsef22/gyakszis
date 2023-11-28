using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalExercise
{
    internal class sharpie
    {
        public string color;
        public int width;
        public int inkAmount;

        public sharpie(string color, int width)
        {
            this.color = color;
            this.width = width;
            inkAmount = 100;
        }

        public sharpie()
        {
            color = "blue";
            width = 2;
            inkAmount = 100;
        }

        public void Use()
        {
            inkAmount -= 10;
        }
    }
}

