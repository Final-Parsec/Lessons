using System;

namespace Lesson3
{
    class DoingMath
    {
        static void Main(string[] args)
        {

            //***********
            //Console.Write("Enter an Int : ");
            //int int1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another Int: ");
            //int int2 = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine(int1 + " * " + int2 + " = " + int1 * int2); // 4, 2
            ////Console.WriteLine(int1 + " + " + int2 + " = " + int1 + int2);

            ////Console.WriteLine(int1 + " * " + int2 + " = " + (int1 * int2));
            ////Console.WriteLine(int1 + " + " + int2 + " = " + (int1 + int2));

            //Console.WriteLine(int1 + " / " + int2 + " = " + (int1 / int2));
            //Console.WriteLine(int2 + " / " + int1 + " = " + (int2 / int1));
            //Console.WriteLine(int2 + " / " + int1 + " = " + (int2 / (double)int1)); // Downcasting or Explicit Cast
            //Console.WriteLine(int2 + " / " + int1 + " = " + ((double)int2 / int1)); // Downcasting or Explicit Cast
            //***********

            //***********
            Console.Write("Enter a Double: ");
            double double1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another Double: ");
            double double2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(double1 + " / " + double2 + " = " + (double1 / double2)); // 4, 2
            Console.WriteLine(double2 + " / " + double1 + " = " + (double2 / double1)); // .4, .2

            Console.WriteLine(double1 + " + " + double2 + " = " + (double1 + double2));
            Console.WriteLine(double1 + " - " + double2 + " = " + (double1 - double2));
            // Computer isn't able to represent some numbers accuratly.
            // The same way that .33 + .33 + .33 != 1

            double addResult = double1 + double2;// .6000000000001
            double roundedResult = Math.Round(addResult, 1);

            Console.WriteLine(double1 + " + " + double2 + " = " + roundedResult);
        }
    }
}
