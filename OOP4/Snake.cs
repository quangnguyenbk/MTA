using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class Snake : Person
    {
        public override void go()
        {
            Console.WriteLine("snake go");
        }

        public override void run()
        {
            Console.WriteLine("snake run");
        }
    }
}
