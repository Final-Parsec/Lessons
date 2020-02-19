using System;

namespace Lesson7
{
    class ForLoops
    {
        static void Main(string[] args)
        {

            int x = 0;
            x = x + 1; // x = 1
            x++;       // x = 2
            x++;       // x = 3
            Console.WriteLine("x = " + x);
            x--;       // x = 2
            Console.WriteLine("x = " + x);

            int y = 0;
            y = y + 2;  // y = 2
            y += 2;     // y = 4
            Console.WriteLine("y = " + y);
            y -= 3; // y = 1
            Console.WriteLine("y = " + y);

            //  /=
            //  *=

            // Modify the same loop instead of making new ones
            int a = 0;
            while (a < 10)
            {
                Console.Write("| a = " + a);

                a++;
            }

            Console.WriteLine();


            for (int b = 0; b < 10; b++)
            {
                Console.Write("| b = " + b);
            }

            Console.WriteLine();


            for (int c = 0; c < 20; c += 2)
            {
                Console.Write("| c = " + c);
            }

            Console.WriteLine();


            for (int d = 50; d >= 40; d--)
            {
                Console.Write("| d = " + d);
            }

            Console.WriteLine();


            for (int e = 1; e <= 125; e = e * 5)
            {
                Console.Write("| e = " + e);
            }

        }
    }
}
