using System;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivan";
            string lastName = "Logutov";
            Console.WriteLine(lastName + " " + name);
            int age = 17;
            int futureLife = 40;
            int newLife = futureLife - age;
            Console.WriteLine("Time to start a new life: " + newLife);
        }
    }
}