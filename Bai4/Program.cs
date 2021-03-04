using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
            int total = 0;
            while (i <= n)
            {
                total = total + i;
                i++;
            }
            Console.WriteLine("total: " + total);

            int k = 20;
            int j = 50;
            while (k <= j)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
        }
    }
}
