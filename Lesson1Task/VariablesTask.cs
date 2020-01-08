/*
* TASK:
* 
* In this program you will need to make the following variables with the given data types:
*   myName      -   Holds a string value
*   myAge       -   Holds an int value
*   someDecimal -   Holds a decimal value between 0 and 1 ex: .223
*   
* Use string concatination and Console.WriteLine to print:
*   Hello, My name is <myName>
*   I am <myAge>
*   A number between 0 and 1 is <someDecimal>
*   
* Where the variable contents are displayed between the <>
*/


// This lets us use Console.WriteLine in our program.
using System;

// We will learn about namespaces in a different lesson.
namespace Lesson1
{
    // We will learn about classes in a different lesson.
    class VariablesTask
    {

        // For now, just know that this is the entry point to our program.
        // The code between the {} is the first section of code that will run.
        static void Main(string[] args)
        {
            // This is a single line comment. It has no effect on the program.
            // It is used to write notes about what the code is doing.
            // ↓↓ Write a comment with your name and today's date under this line ↓↓


            /*
               This is a block comment.
               It can be used for multi lined comments.

               Make a NEW Block comment under this line 
               with your name and today's date on seperate lines

               ↓    ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓
             */


            // I'll start out with an example.
            // This variable is named introText and holds a string data type.
            // Use the equalsign(=) to set the variable's value.  = Is called the assignment operator
            string introText = "Variables!"; //  <-- end lines of code with a ;
            Console.WriteLine("Today I'm going to learn " + introText);


            //Make a variable named myName with the string data type.
            //Set the variable equal to your name.
            //Display the text 'Hello, My name is <myName>'


            //Make a variable named myAge with the int data type.
            //Set the variable equal to your age.
            //Display the text 'I am <myAge>'


            //Make a variable named someDecimal with the decimal data type.
            //Set the variable equal to a number between 0 and 1. ex: .223
            //Display the text 'A number btween 0 and 1 is <someDecimal>'


        } // This curly brace ends Main 
    } // This curly brace ends VariablesTask
} // This curly brace ends Lesson1Task
