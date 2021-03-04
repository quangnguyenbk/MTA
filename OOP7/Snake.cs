using System;
using System.Collections.Generic;
using System.Text;

namespace OOP7
{
    class Snake : Animal, DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("Snake drink");
        }

        public override void eat()
        {
            Console.WriteLine("Snake eat");
        }

        public void sanmoi()
        {
            Console.WriteLine("Snake san moi");
        }
    }
}
