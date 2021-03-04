using System;
using MyNamespace;
namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("Quang", 24);
            Person person = new Person("abc", 11);
            em.BasicSalary = 18000;
            Console.WriteLine(em.CalculateSalary(1500, 6000));
        }
    }
}
