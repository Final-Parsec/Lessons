using System;

namespace Lesson4
{
    class TrueAndFalse
    {
        static void Main(string[] args)
        {
            bool trueValue = true;
            bool falseValue = false;

            Console.WriteLine("This is a true value:\t" + trueValue);
            Console.WriteLine("This is a false value:\t" + falseValue);

            Console.WriteLine();

            Console.WriteLine("True IS EQUALE TO False:\t" + (trueValue == falseValue));
            //***********
            Console.WriteLine("True IS NOT EQUAL TO False: \t" + (trueValue != falseValue));
            //***********

            int bigNumber = 9000;
            int smallNumber = 1;

            Console.WriteLine("bigNumber IS GREATER THAN smallNumber:\t" + (bigNumber > smallNumber));
            Console.WriteLine("bigNumber IS LESS THAN smallNumber:\t" + (bigNumber < smallNumber));

            int smallNumber2 = smallNumber;

            Console.WriteLine();
            Console.WriteLine("smallNumber IS GREATER THAN smallNumber2:\t" + (smallNumber > smallNumber2));
            Console.WriteLine("smallNumber IS GREATER THAN OR EQUAL TO smallNumber2:\t" + (smallNumber >= smallNumber2));

            Console.WriteLine("smallNumber EQUALS smallNumber2:\t" + (smallNumber == smallNumber2));
            Console.WriteLine("smallNumber IS NOT EQUAL TO bigNumber:\t" + (smallNumber != bigNumber));

            /* Comparison Operators
             * ==
             * !=
             * >
             * <
             * >=
             * <=
             */

        }
    }
}
