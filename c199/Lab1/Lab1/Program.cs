/* W8172
 * 28 January 2018
 * Cis-199-01
 * Lab 1
 * Write an interactive console application that reads two floating point numbers (use float or double type) from the user and prints the results of the following calculations:
 * Sum
 * Difference (first number minus second number)
 * Product
 * Quotient (first number divided by second number)
 * Mean (sum of the numbers divided by 2)
 *
 * Be sure to provide clear prompts to the user for their input and label all output as shown below. 
 * Display all numbers using 3 places of precision. 
 * Hint: you can use format code F3 to achieve this when formatting your output.
*/

using System;
using static System.Console;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne;      //variable to hold first input.
            double numTwo;      //variable to hold second input.
            double sum;         //Variable to hold the solution to the addition of the 2 inputs.
            double dif;         //Variable to hold the solution to the subtraction of the 2 inputs.
            double prod;        //Variable to hold the solution to the multiplication of the 2 inputs.
            double quot;        //Variable to hold the solution to the division of the 2 inputs.
            double mean;        //Variable to hold the solution to the mean of the 2 inputs.

            //This section asks for input, reads the numbers input, and assigns them as a double to a variable.
            Write("Enter the first number : ");
            numOne = double.Parse(ReadLine());
            Write("Enter the second number : ");
            numTwo = double.Parse(ReadLine());

            //This section does the calculations of the 2 inputs and assigns the answer to the proper variable.
            sum = numOne + numTwo;
            dif = numOne - numTwo;
            prod = numOne * numTwo;
            quot = numOne / numTwo;
            mean = (numOne + numTwo) / 2;

            //This section prints all the calulations and answers to the dispay.
            WriteLine($"{numOne:f3} + {numTwo:f3} = {sum:f3}");
            WriteLine($"{numOne:f3} - {numTwo:f3} = {dif:f3}");
            WriteLine($"{numOne:f3} * {numTwo:f3} = {prod:f3}");
            WriteLine($"{numOne:f3} / {numTwo:f3} = {quot:f3}");
            WriteLine("---Mean of");
            WriteLine($"{numOne:f3} , {numTwo:f3} = {mean:f3}");
        }
    }
}
