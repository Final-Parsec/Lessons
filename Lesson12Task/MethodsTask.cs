/*
 * TASK
 * 
 * You are creating a password creation tool.
 * A password has to meet 4 requirements...
 *      -Contain at least 1 upper case letter.
 *      -Contain at least 1 lower case letter.
 *      -Contain one of these special characters !#$%&
 *      -Be more than 8 characters long.
 * 
 * Create 4 methods to check if the password is 'Valid' or 'Invalid'.
 * One method for each of the requirements.
 * 
 * I have started the program by prompting the user and checking the first requirement.
 * 
 */

using System;

namespace Lesson12Task
{
    class MethodsTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A password must be...");
            Console.WriteLine("Contain at least 1 upper case letter.");
            Console.WriteLine("Contain at least 1 lower case letter.");
            Console.WriteLine("Contain one of these special characters !#$%&");
            Console.WriteLine("Be more than 8 characters long.");
            Console.WriteLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool containsUpperCase = CheckUpperCase(password);

            if (containsUpperCase)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }

        static bool CheckUpperCase(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 65 && password[i] <= 'Z')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
