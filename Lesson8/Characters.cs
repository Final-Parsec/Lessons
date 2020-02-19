using System;

namespace Lesson8
{
    class Characters
    {
        static void Main(string[] args)
        {
            // b
            // 2
            // !
            // Ñ

            Console.OutputEncoding = System.Text.Encoding.UTF8;// Add this last

            char myFirstChar = 'Ñ';
            Console.WriteLine("Char: " + myFirstChar + " | Int: " + Convert.ToInt32(myFirstChar));

            for (int x = 1; x <= 209; x++)
            {
                char numberToChar = Convert.ToChar(x);
                Console.WriteLine($"count {x} : {numberToChar}"); // Show ascii/unicode table after this
            }

        }
    }
}
