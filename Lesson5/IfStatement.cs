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
            //Console.WriteLine("Enter x: ");
            //int x =  Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter y: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x > y)
            //{
            //    Console.WriteLine("x is bigger than y.");
            //}
            //else if (y > x)
            //{
            //    Console.WriteLine("y is bigger than x.");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers are the same!");
            //}
            //***********************************************


            Console.WriteLine("What planet are we on?");
            string planet = Console.ReadLine();

            if (planet == "Earth")
            {
                Console.WriteLine("Earth is correct");
            }
            else
            {
                Console.WriteLine(planet + " is wrong");
            }

            //************************************************

            Console.WriteLine("How many sides are on a cube?");
            int sides = Convert.ToInt32(Console.ReadLine());

            if (sides != 6)
            {
                Console.WriteLine(sides + " is wrong");
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
