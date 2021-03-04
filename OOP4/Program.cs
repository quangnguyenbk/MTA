using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Bird();
            person.go();

            Snake snake = new Snake();
            snake.run();

            Dog dog = new Dog();
            dog.run();
        }
    }
}
