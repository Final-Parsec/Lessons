using System;

namespace Lesson3
{
    class DoingMath
    {
        static void Main(string[] args)
        {

            //***********
            Console.Write("Enter an Int : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another Int: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + " * " + y + " = " + x * y); // 4, 2
            Console.WriteLine(x + " + " + y + " = " + x + y);

            Console.WriteLine(x + " * " + y + " = " + (x * y));
            Console.WriteLine(x + " + " + y + " = " + (x + y));

            Console.WriteLine(x + " / " + y + " = " + (x / y));
            Console.WriteLine(y + " / " + x + " = " + (y / x));
            Console.WriteLine(y + " / " + x + " = " + (y / (double)x)); // Downcasting or Explicit Cast
            Console.WriteLine(y + " / " + x + " = " + ((double)y / x)); // Downcasting or Explicit Cast
            //***********

            //***********
            Console.Write("Enter a Double: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another Double: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a + " / " + b + " = " + (a / b)); // 4, 2
            Console.WriteLine(b + " / " + a + " = " + (b / a)); // .4, .2

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            // Computer isn't able to represent some numbers accuratly.
            // The same way that .33 + .33 + .33 != 1

            double addResult = a + b;// .6000000000001
            double roundedResult = Math.Round(addResult, 1);

            Console.WriteLine(a + " + " + b + " = " + roundedResult);
        }
    }
}
