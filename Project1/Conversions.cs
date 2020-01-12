/*
* TASK:
*   NOTE: You can assume user input will always be valid
* 
*   Make a program that can do 3 basic conversions:
*       kilometers and miles,
*       celsius and fahrenheit,
*       kilograms and pounds
*   
*   Ask what kind of converstion the user wants to perform:
*       
*       Would you like to convert:
*       1: Distance
*       2: Temperature
*       3: Weight
*       0: Exit
*   
*   The number is what the user will enter.
*   After that selection is made, The user must choose what to convert.
*       
*       Would you like to convert:
*       1: Distance
*       2: Temperature
*       3: Weight
*       0: Exit
*       1
*       
*       1: Kilometers to Miles
*       2: Miles to Kilometers
*       1
*       1 Kilometer(s) is 0.62137 Mile(s)
*       
*   After the answer is displayed the program will keep looping untill the user selects 0 to Exit.
*       
*       Would you like to convert:
*       1: Distance
*       2: Temperature
*       3: Weight
*       0: Exit
*       1
*       
*       1: Kilometers to Miles
*       2: Miles to Kilometers
*       1
*       1 Kilometer(s) is 0.62137 Mile(s)
*       
*       Would you like to convert:
*       1: Distance
*       2: Temperature
*       3: Weight
*       0: Exit
*       0
*       
*       Goodbye
*       
*   
* 
*   Conversion formulas
*       Kilometer to Mile:      mi = km * 0.62137
*       Mile to Kilometer:      km = mi / 0.62137
*       
*       Kilogram to Pound:      lb = kg * 2.2046
*       Pound to Kilogram:      kg = lb / 2.2046
*       
*       Celsius to Fahrenheit:  F = (C * 1.8) + 32
*       Fahrenheit to Celsius:  C = (F - 32) / 1.8
*/


using System;

namespace Project1
{
    class Conversions
    {
        static void Main(string[] args)
        {
            
            // Where to start?
            // Step1: Make a while loop that exits when the input is 0              - LESSON 6
                // Step2: Make an if statement that is true when the input is 1     - LESSON 4, LESSON 5
                    // Step3: Make another if that takes 1
                        // Step4: Do the correct conversion                         - LESSON 3

            // TIP: Remember that Console.ReadLine() returns a string
            //      a string "0" IS NOT the same as an Int 0
        }
    }
}
