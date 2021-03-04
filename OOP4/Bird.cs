using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class Bird : Person
    {
        public override void go()
        {
            Console.WriteLine("bird go");
        }

        public override void run()
        {
            Console.WriteLine("bird run");
        }
    }
}
