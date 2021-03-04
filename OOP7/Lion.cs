using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7
{
    class Lion : Animal, DongVatAnThit
    {
        public static int Age = 100;
        public static void vomoi()
        {
            Console.WriteLine("Lion vo moi");
        }
        public override void drink()
        {
            Console.WriteLine("Lion drink");
        }

        public override void eat()
        {
            Console.WriteLine("Lion eat");
        }

        public void sanmoi()
        {
            Console.WriteLine("Lion san moi");
        }
    }
}
