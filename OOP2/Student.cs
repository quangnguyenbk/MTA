using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Student
    {
        int id;
        string name;
        int age;
        string address;

        public Student(int id, string name, int age, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }

        public void display()
        {
            Console.WriteLine("name: " + this.name + " id: " + id + " age: " + age + " address: " + address);
        }
    }
}
