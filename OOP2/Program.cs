using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int total = 6;
            for (int i = 0; i < total; i++)
            {
                students.Add(new Student(i, "abc" + i, i, "Nxyz" + i));
            }
            students.Add(new Student(199, "abc", 199, "123"));
            int totalEven = 0;
            int totalAge = 0;
            foreach (Student s in students)
            {
                s.display();
                totalAge += s.Age;
                if (s.Id % 2 == 0)
                    totalEven++;
            }

            Console.WriteLine("totalEven:" + totalEven);
            Console.WriteLine("tuoi trung binh:" + (double)totalAge/students.Count);
            Console.WriteLine("Bat dau bang chu N:");
            foreach (Student s in students)
            {
                if (s.Address.StartsWith("N"))
                {
                    s.display();
                }
            }
        }
    }
}
