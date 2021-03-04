using System;
using System.Collections.Generic;
using System.Text;

namespace MyNamespace
{
    class Employee : Person
    {
        public double BasicSalary { get; set; }

        public Employee(string Name, int Age) : base(Name, Age)
        {
        }

        public double CaculateSalary()
        {
            return BasicSalary;
        }

        public double CalculateSalary(int bonus, int punishment) {
            return BasicSalary + bonus - punishment;
        }

        public double CaculateSalary(int bonus, int punishment, int extra)
        {
            return BasicSalary + bonus - punishment + extra;
        }
    }
}
