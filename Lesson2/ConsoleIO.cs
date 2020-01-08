using System;

namespace Lesson2
{
    class ConsoleIO
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");

            double value;
            Console.WriteLine("What is the decimal value of 1/10?");
            value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("I hope " + value + " is right!");

        }
    }
}
