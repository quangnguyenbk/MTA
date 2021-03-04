using System;

namespace OOP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion();
            Lion lion2 = new Lion();
            Lion lion3 = new Lion();
            Lion.Age = 66;
            Lion.Age = 77;
            Lion.Age = 88;
            Console.WriteLine("lion1: " + Lion.Age);
        }
    }
}
