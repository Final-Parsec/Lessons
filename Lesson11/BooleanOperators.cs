using System;

namespace Lesson11
{
    class BooleanOperators
    {
        static void Main(string[] args)
        {
            // && - AND
            // || - OR
            // !  - NOT 

            Console.WriteLine("Enter 3 numbers:");
            Console.Write("1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{number1}-{number2}-{number3}");

            if (number1 == 0 || number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number1 && number2 > number3 || number2 == 0)
            {
                Console.WriteLine(number2);
            }
            else if (number3 > number1 && number3 > number2 || number3 == 0)
            {
                Console.WriteLine(number3);
            }


        }
    }
}
