using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalExercise
{
    internal class Counter
    {
        private int counter;
        public static int reset;

        public Counter(int counter)
        {
            this.counter = counter;
            reset = counter;
        }

        public Counter()
        {
            counter = 0;
            reset = counter;
        }



        public void Add() { counter++; }

        public void Add(int number) { counter += number; }

        public int Get() { return counter; }


        public void Reset() { counter = reset; }

    }
}
