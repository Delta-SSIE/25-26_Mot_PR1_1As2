using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    internal class Human
    {
        public string name;
        public int age;
        public int monthSalary;

        //Konstruktor
        public Human(string jmeno, int vek)
        {
            this.name = jmeno;

            if(vek < 1)
            {
                this.age = 1;
            } else if(vek > 110)
            {
                this.age = 110;
            } else
            {
                this.age = vek;
            }

            Random gen = new Random();
            if (this.age < 18)
            {
                this.monthSalary = 0;
            }
            else
            {
                this.monthSalary = gen.Next(22000, 300001);
            } 
            
        }

        public void Introduction()
        {
            Console.WriteLine($"Hello, my name is {this.name} and I am {this.age} yeas old! My salary is {this.monthSalary} kč");
        }

    }
}
