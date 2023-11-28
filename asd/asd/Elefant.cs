using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{

    internal class Elefant : Allatok
    {
        public Elefant(string name, int age, gender gender) : base(name, age, gender)
        {
            weight = 175.25;
            height = 2;
        }

        public Elefant(string name, int age, gender gender, double weight, double height) : base(name, age, gender, weight, height)
        {
        }
    }
}
