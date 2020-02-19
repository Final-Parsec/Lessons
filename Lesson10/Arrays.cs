using System;

namespace Lesson10
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //int[] myFirstArray;
            //myFirstArray = new int[5];

            //myFirstArray[0] = 10; // 1
            //myFirstArray[1] = 20; // 2
            //myFirstArray[2] = 30; // 3
            //myFirstArray[3] = 40; // 4
            //myFirstArray[4] = 50; // 5

            int[] myFirstArray = new int[] { 10, 20, 30, 40, 50 };

            Console.Write("Using For: ");
            for (int i = 0; i < myFirstArray.Length; i++)
            {
                Console.Write(myFirstArray[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Using While: ");
            int j = 0;
            while (j < myFirstArray.Length)
            {
                Console.Write(myFirstArray[j] + " ");

                j++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Enter the length of the array: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            string[] userArray = new string[arrayLength];

            for (int x = 0; x < userArray.Length; x++)
            {
                Console.Write($"Enter value {x}: ");
                userArray[x] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.Write("Entered values: ");

            for (int x = 0; x < userArray.Length; x++)
            {
                Console.Write(userArray[x] + " ");
            }



        }
    }
}
