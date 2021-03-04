using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salary = 560.5F;
            float tax = 10F;
            if (salary > 500)
            {
                Console.WriteLine("Ban phai dong: " + salary * tax/100);
            } else
            {
                Console.WriteLine("Ban khong phai nop thue");
            }
        }
    }
}
