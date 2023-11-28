using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    enum gender { MALE, FEMALE };
    internal class Allatok
    {
        protected string name;
        protected int age;
        protected gender gender;
        protected double weight;
        protected double height;

        public Allatok(string name, int age, gender gender, double weight, double height)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }
        public Allatok(string name, int age, gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            weight = 66.55;
            height = 2.35;
        }


        public string getName() { return name; }
        public int getAge() { return age; }
        public gender getGender() { return gender; }
    }
}
