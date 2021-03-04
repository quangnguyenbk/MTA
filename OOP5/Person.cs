using System;
using System.Collections.Generic;
using System.Text;

namespace OOP5
{
    class Person
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Eat(int speed)
        {
            Console.WriteLine("Eat(int speed)");
        }

        public void Eat(string s)
        {
            Console.WriteLine("Eat(string s)");
        }
    }
}
