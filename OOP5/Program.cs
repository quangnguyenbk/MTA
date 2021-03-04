using System;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            em.Eat(50);
            em.Display();

            Doctor doctor = new Doctor();
            doctor.Eat("rice");
            doctor.Display();
        }
    }
}
