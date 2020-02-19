using System;

namespace Lesson9
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            string alphabet = "abcd";
            for (int index = 0; index < alphabet.Length; index++)
            {
                //string letter = alphabet[index]; // Doesn't work
                char letter = alphabet[index];
                Console.WriteLine($"char at index {index}: {letter}");
            }

            //Index out of bounds rant
            string reverse = "";
            for (int index = alphabet.Length - 1; index >= 0; index--)
            {
                //string letter = alphabet[index]; // Doesn't work
                char letter = alphabet[index];
                Console.WriteLine($"char at index {index}: {letter}");
                reverse += letter;
            }

            Console.WriteLine(reverse);


            // using ToLower and ToUpper for string compaire
            string userInput;
            
            do
            {
                Console.Write("Type 'exit' to quit: ");
                userInput = Console.ReadLine();

            } while (userInput.ToUpper() != "exit");


        }
    }
}
