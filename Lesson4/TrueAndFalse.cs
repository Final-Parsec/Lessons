using System;

namespace Lesson4
{
    class TrueAndFalse
    {
        static void Main(string[] args)
        {

            // true, false
            // 1   , 0

            bool trueValue = true;
            Console.WriteLine("This is a true value:\t" + trueValue);

            bool falseValue = false;
            Console.WriteLine("This is a false value:\t" + falseValue);

            /* Comparison Operators
             * ==,  IS EQUAL TO
             * !=,  IS NOT EQUAL TO
             * >,   GREATER THAN
             * <,   LESS THAN
             * >=,  GREATER THAN OR EQUAL TO
             * <=,  LESS THAN OR EQUAL TO
             */

            bool value1 = 7 == 7;
            Console.WriteLine("7 IS EQUALE TO 7:\t" + value1);

            bool value2 = 7 != 7;
            Console.WriteLine("7 IS NOT EQUAL TO 7: \t" + value2);

            bool value3 = 99 > 1;
            Console.WriteLine("99 IS GREATER THAN 1:\t" + value3);

            bool value4 = 99 < 1;
            Console.WriteLine("99 IS LESS THAN 1:\t" + value4);

            bool value5 = 2 >= 1;
            Console.WriteLine("2 is greaterthan or equal to 1: " + value5);

            bool value6 = 2 <= 2;
            Console.WriteLine("2 is lessthan or equal to 2: " + value6);

            bool value7 = "cup" == "CUP";
            Console.WriteLine("cup is equal to CUP: " + value7);
        }
    }
}
