using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class Dog : Person
    {
        public override void go()
        {
            Console.WriteLine("dog go");
        }

        public override void run()
        {
            Console.WriteLine("dog run");
        }
    }
}
