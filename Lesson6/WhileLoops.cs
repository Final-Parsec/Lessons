using System;

namespace Lesson6
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            // While loops are similar to if statements

            //if (true) // runs once if true
            //{
            //    Console.WriteLine("The IF is true");
            //}

            //while (true) // repeats until value is not true
            //{
            //    Console.WriteLine("The While is true");
            //}

            int numberOfLoops = 0;

            while (numberOfLoops < 10) // while(true)
            {
                numberOfLoops = numberOfLoops + 1;
                Console.WriteLine("numberOfLoops: " + numberOfLoops);
            }

            string userInput;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1: Cows go");
                Console.WriteLine("2: Cats go");
                Console.WriteLine("3: EXIT");
                Console.Write("Choose an action: ");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Mooooo");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Meow");
                }
                else if (userInput != "3")
                {
                    Console.WriteLine("Your choice is not valid");
                }

            } while (userInput != "3");

        }
    }
}
