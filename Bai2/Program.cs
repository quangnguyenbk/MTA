using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;
            if (number > 100 || number < 0)
            {
                Console.WriteLine("khong hop le");
            }
            else if (number > 80)
            {
                Console.WriteLine("gioi");
            }
            else if (number >= 70)
            {
                Console.WriteLine("kha");
            }
            else if (number >= 60)
            {
                Console.WriteLine("TB kha");
            }
            else if (number >= 50)
            {
                Console.WriteLine("TB");
            }
            else Console.WriteLine("yeu");
        }
    }
}
