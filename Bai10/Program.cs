using System;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(i + " ");
                Console.WriteLine();
            }

            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i * j + " ");
                Console.WriteLine();
            }
        }
    }
}
