using System;

namespace Lesson12
{
    class Methods
    {
        // A method needs to be delared inside a class

        static void Main()
        {
            RunProgram();
        }

        static void RunProgram()
        {
            string name = PromptTheUser("What is your name?");

            // Make a method to ask the user for their age
            //  int age = PromptTheUserForInt("What is your age?");
            int age = PromptTheUserForInt("What is your age?");

            Console.WriteLine($"Your name is {name} and you are {age} years old");
        }

        static int PromptTheUserForInt(string prompt)
        {
            Console.WriteLine(prompt);
            int userInput = Convert.ToInt32(Console.ReadLine());

            return userInput;
        }

        static string PromptTheUser(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();

            return userInput;
        }

    }
}
