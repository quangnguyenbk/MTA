using System;

namespace OOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Di();
            s.Di(100);
            Person p = s;
            p.Di();


        }
    }
}
