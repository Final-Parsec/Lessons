using System;

namespace Lesson5
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("This will always be true.");
            }

            if (false)
            {
                Console.WriteLine("This will never be true.");
            }

            //*********************************************
            //Console.Write("Enter number1: ");
            //int number1 =  Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number2: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1 > number2)
            //{
            //    Console.WriteLine("number1 is bigger than number2.");
            //}
            //else if (number2 > number1)
            //{
            //    Console.WriteLine("number2 is bigger than number1.");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers are the same!");
            //}
            //***********************************************


            Console.WriteLine("What planet are we on?");
            string planetAnswer = Console.ReadLine();

            if (planetAnswer == "Earth")
            {
                Console.WriteLine("Earth is correct");
            }
            else
            {
                Console.WriteLine(planetAnswer + " is wrong");
            }

            //************************************************

            Console.WriteLine("How many sides are on a cube?");
            int cubeAnswer = Convert.ToInt32(Console.ReadLine());

            if (cubeAnswer != 6)
            {
                Console.WriteLine(cubeAnswer + " is wrong");
            }
            else
            {
                Console.WriteLine("6 is correct");
            }

            //*************************************************

            Console.WriteLine("Input a number greater than 9.0");
            double nineAnswer = Convert.ToDouble(Console.ReadLine());

            if (nineAnswer > 9.0)
            {
                Console.WriteLine(nineAnswer + " is correct");
            }
            else
            {
                Console.WriteLine(nineAnswer + "is wrong");
            }


        }
    }
}
