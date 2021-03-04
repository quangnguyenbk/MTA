using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7
{
    class Person : Animal,DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("person drink");
        }

        public override void eat()
        {
            Console.WriteLine("person eat");
        }

        public void sanmoi()
        {
            Console.WriteLine("person san moi");
        }
    }
}
