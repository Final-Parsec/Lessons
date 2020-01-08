using System;

namespace Lesson1
{
    class Variables
    {
        static void Main(string[] args)
        {

            string myString;
            myString = "This is a string value.";

            string mySecondString;
            mySecondString = "1000";

            int myInt;
            myInt = 1000;

            int mySecondInt = 2;

            Console.WriteLine(myString);
            Console.WriteLine("My second string: " + mySecondString);
            Console.WriteLine("My int: " + myInt);
            Console.WriteLine("My second int: " + mySecondInt);

            double myDouble = 3.14;
            Console.WriteLine("My Double: " + myDouble);

            Console.WriteLine("Goodbye");

        }
    }
}
