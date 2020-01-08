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


            Console.WriteLine("Type 'exit' to end the program.");
            string userInput = Console.ReadLine();

            while (userInput != "exit") 
            {
                Console.WriteLine("You did not enter 'exit'");
                userInput = Console.ReadLine();
            }
        }
    }
}
