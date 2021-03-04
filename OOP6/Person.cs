using System;
using System.Collections.Generic;
using System.Text;

namespace OOP6
{
    class Person
    {
        string Ten;
        string DiaChi;
        int Tuoi;

        public Person()
        {
        }

        public Person(string ten, string diaChi, int tuoi)
        {
            Ten = ten;
            DiaChi = diaChi;
            Tuoi = tuoi;
        }

        public virtual void Di()
        {
            Console.WriteLine("Person Di");
        }

        public virtual void Di(int speed)
        {
            Console.WriteLine("Person Di:" + speed + "km");
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
    }
}
